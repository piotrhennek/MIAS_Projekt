using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Vici.CoolStorage;

namespace MIAS_CoolStorage.Connection
{//https://searchcode.com/codesearch/view/46434162/
    public class CSDataProviderSqlServer : CSDataProvider
    {
        private int _serverVersion = 0;

        public CSDataProviderSqlServer(string connectionString) : base(connectionString)
        {
        }
        protected override void ClearConnectionPool()
        {
            SqlConnection.ClearAllPools();
        }

        public CSDataProviderSqlServer(string serverName, string databaseName)
            : this("Initial Catalog=" + databaseName + ";Data Source=" + serverName + ";Integrated Security=true;")
        {

        }

        protected override bool RequiresSeperateIdentityGet
        {
            get
            {
                return false;
            }
        }

        protected override bool SupportsMultipleStatements
        {
            get
            {
                return true;
            }
        }

        protected override bool SupportsNestedTransactions
        {
            get
            {
                return false;
            }
        }

        protected override bool SupportsSequences
        {
            get
            {
                return false;
            }
        }

        protected override string BuildInsertSQL(string tableName, string[] columnList, string[] valueList, string[] primaryKeys, string[] sequences, string identityField)
        {
            string sql;

            if (columnList.Length > 0)
            {
                sql = String.Format("insert into {0} ({1}) values ({2})",
                                    QuoteTable(tableName),
                                    String.Join(",", QuoteFieldList(columnList)),
                                    String.Join(",", valueList)
                    );
            }
            else
            {
                sql = String.Format("insert into {0} default values", QuoteTable(tableName));
            }

            if (primaryKeys != null && primaryKeys.Length > 0 && identityField != null)
                sql += String.Format(";SELECT {0} from {1} where {2} = SCOPE_IDENTITY()",
                                     String.Join(",", QuoteFieldList(primaryKeys)), QuoteTable(tableName), identityField);

            return sql;
        }

        protected override string BuildSelectSQL(string tableName, string tableAlias, string[] columnList, string[] columnAliasList, string[] joinList, string whereClause, string orderBy, int startRow, int maxRows, bool quoteColumns, bool unOrdered)
        {
            string sqlColumns;
            string sqlFromTable;
            string sqlJoins;
            string sqlWhere;
            string sqlOrderBy;

            if (quoteColumns)
                columnList = QuoteFieldList(columnList);

            string[] columnNames = new string[columnList.Length];

            for (int i = 0; i < columnList.Length; i++)
            {
                columnNames[i] = columnList[i];

                if (columnAliasList != null)
                    columnNames[i] += " " + columnAliasList[i];
            }

            sqlColumns = String.Join(",", columnNames);
            sqlFromTable = " FROM " + QuoteTable(tableName) + " " + tableAlias;

            if (joinList != null && joinList.Length > 0)
                sqlJoins = " " + String.Join(" ", joinList);
            else
                sqlJoins = "";

            if (!string.IsNullOrEmpty(whereClause))
                sqlWhere = " WHERE " + whereClause;
            else
                sqlWhere = "";

            if (!string.IsNullOrEmpty(orderBy))
                sqlOrderBy = " ORDER BY " + orderBy;
            else
                sqlOrderBy = "";


            if (startRow > 1)
            {
                if ((orderBy ?? "").Length < 1)
                    throw new CSException("When selecting a range, a sort order is required");

                if (_serverVersion < 9)
                    throw new CSException("Paging is not supported on SQL Server 2000 or earlier versions");

                return "select "
                        + String.Join(",", columnAliasList)
                        + " from (select row_number() over (ORDER BY " + orderBy + ") rownumber, "
                                + sqlColumns
                                + sqlFromTable
                                + sqlJoins
                                + sqlWhere
                         + ")  "
                         + tableAlias + "XXX"
                         + " where rownumber between " + startRow + " and " + (startRow + maxRows - 1) + (unOrdered ? "" : " order by rownumber");
            }
            else
            {
                string sql = "SELECT";

                if (maxRows > 0)
                    sql += " TOP " + maxRows;

                return sql + " " + sqlColumns + sqlFromTable + sqlJoins + sqlWhere + (unOrdered ? "" : sqlOrderBy);
            }
        }

        protected override CSDataProvider Clone()
        {
            throw new NotImplementedException();
        }

        protected override ICSDbCommand CreateCommand(string sqlQuery, CSParameterCollection parameters)
        {
            SqlCommand sqlCommand = ((CSSqlCommand)Connection.CreateCommand()).Command;

            if (CurrentTransaction != null)
                sqlCommand.Transaction = ((CSSqlTransaction)CurrentTransaction).Transaction;

            if (sqlQuery.StartsWith("!"))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = sqlQuery.Substring(1);
            }
            else
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = sqlQuery;
            }

            if (parameters != null && !parameters.IsEmpty)
                foreach (CSParameter csParameter in parameters)
                {
                    IDbDataParameter dataParameter = sqlCommand.CreateParameter();
                    
                    dataParameter.ParameterName = csParameter.Name;
                    //2011-05-09 - DAE - Se agrego el soporte para parametros de salida
                    //dataParameter.Direction = ParameterDirection.Input;
                    //dataParameter.Direction = csParameter.Direction;
                    //if (csParameter.Direction.BitOn(ParameterDirection.Input))
                    //    dataParameter.Value = ConvertParameter(csParameter.Value);

                    //if (csParameter.Size.HasValue)
                    //    dataParameter.Size = csParameter.Size.Value;

                    //if (csParameter.Precision.HasValue)
                    //    dataParameter.Precision = csParameter.Precision.Value;

                    //if (csParameter.Scale.HasValue)
                    //    dataParameter.Scale = csParameter.Scale.Value;
                    dataParameter.ParameterName = "?" + csParameter.Name.Substring(1);
                    dataParameter.Direction = ParameterDirection.Input;
                    dataParameter.Value = ConvertParameter(csParameter.Value);
                    sqlCommand.Parameters.Add(dataParameter);
                }

            return new CSSqlCommand(sqlCommand);
        }

        protected override ICSDbConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            _serverVersion = Convert.ToInt32(conn.ServerVersion.Substring(0, 2));
            return new CSSqlConnection(conn);
        }

        protected override CSSchemaColumn[] GetSchemaColumns(string tableName)
        {
            using (ICSDbConnection newConn = CreateConnection())
            {
                ICSDbCommand dbCommand = newConn.CreateCommand();

                dbCommand.CommandText = "select * from " + QuoteTable(tableName);

                using (CSSqlReader dataReader = (CSSqlReader)dbCommand.ExecuteReader(CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo))
                {
                    List<CSSchemaColumn> columns = new List<CSSchemaColumn>();

                    DataTable schemaTable = dataReader.Reader.GetSchemaTable();

                    bool hasHidden = schemaTable.Columns.Contains("IsHidden");
                    bool hasIdentity = schemaTable.Columns.Contains("IsIdentity");
                    bool hasAutoincrement = schemaTable.Columns.Contains("IsAutoIncrement");

                    foreach (DataRow schemaRow in schemaTable.Rows)
                    {
                        CSSchemaColumn schemaColumn = new CSSchemaColumn();

                        if (hasHidden && !schemaRow.IsNull("IsHidden") && (bool)schemaRow["IsHidden"])
                            schemaColumn.Hidden = true;

                        schemaColumn.IsKey = (bool)schemaRow["IsKey"];
                        schemaColumn.AllowNull = (bool)schemaRow["AllowDBNull"];
                        schemaColumn.Name = (string)schemaRow["ColumnName"];
                        schemaColumn.ReadOnly = (bool)schemaRow["IsReadOnly"];
                        schemaColumn.DataType = (Type)schemaRow["DataType"];
                        schemaColumn.Size = (int)schemaRow["ColumnSize"];

                        if (hasAutoincrement && !schemaRow.IsNull("IsAutoIncrement") && (bool)schemaRow["IsAutoIncrement"])
                            schemaColumn.Identity = true;

                        if (hasIdentity && !schemaRow.IsNull("IsIdentity") && (bool)schemaRow["IsIdentity"])
                            schemaColumn.Identity = true;

                        columns.Add(schemaColumn);
                    }

                    return columns.ToArray();
                }
            }
        }

        protected override string NativeFunction(string functionName, ref string[] parameters)
        {
            switch (functionName.ToUpper())
            {
                default:
                    return functionName.ToUpper();
            }
        }

        protected override string QuoteField(string fieldName)
        {
            int dotIdx = fieldName.IndexOf('.');

            if (dotIdx > 0)
                return fieldName.Substring(0, dotIdx + 1) + "[" + fieldName.Substring(dotIdx + 1) + "]";
            else
                return "[" + fieldName + "]";
        }

        protected override string QuoteTable(string tableName)
        {
            return "[" + tableName.Replace(".", "].[") + "]";
        }
    }
}
