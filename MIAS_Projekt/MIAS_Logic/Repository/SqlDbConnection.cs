using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic.Repository
{
    public class SqlDbConnection : IDbConnection
    {
        private SqlConnection connection { get; set; }

        public SqlDbConnection()
        {
            connection = new SqlConnection(DatabasesConfig.SqlConnectionString);
        }
        public int RunQuery(string query)
        {
            Connect();
            var cmd = connection.CreateCommand();
            cmd.CommandText = query;
            var adapter = new SqlDataAdapter(cmd);
            SqlDataReader reader = adapter.SelectCommand.ExecuteReader();
            return GetRowsCount(reader);
        }

        private void Dispose()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Dispose();
        }

        private void Connect()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }


        private int GetRowsCount(SqlDataReader reader)
        {
            int counter = 0;
            while (reader.Read())
            {
                counter++;
            }
            Dispose();
            return counter;
        }
    }
}
