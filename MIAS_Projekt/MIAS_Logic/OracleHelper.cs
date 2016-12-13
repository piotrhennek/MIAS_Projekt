#region Usings

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using Oracle.ManagedDataAccess.Client;


using ArgumentNullException = System.ArgumentNullException;

#endregion
namespace MIAS_Logic
{


    public static class OracleHelper
    {
        #region Private constants
        private const string CnstQueryParameterPrefix = ":Parameter";
        #endregion

        #region Methods
 public static long GetLongRequired(OracleDataReader reader, string fieldName)
        {

            // Get the field index
            int fieldIndex = reader.GetOrdinal(fieldName);

            // Return the field value
            return reader.GetInt64(fieldIndex);
        }

 public static long GetLongRequired(OracleDataReader reader, Enum fieldName)
        {
            return GetLongRequired(reader, fieldName.ToString());
        }

        public static double? GetDouble(OracleDataReader reader, string fieldName)
        {

            // Get the field index
            int fieldIndex = reader.GetOrdinal(fieldName);

            // Check if the field is null
            if (reader.IsDBNull(fieldIndex))
            {
                return null;
            }

            // Return the field value
            return reader.GetDouble(fieldIndex);
        }

        public static double? GetDouble(OracleDataReader reader, Enum fieldName)
        { 
            return GetDouble(reader, fieldName.ToString());
        }

        public static double GetDoubleRequired(OracleDataReader reader, string fieldName)
        {
            // Get the field index
            int fieldIndex = reader.GetOrdinal(fieldName);

            // Return the field value
            return reader.GetDouble(fieldIndex);
        }

        public static double GetDoubleRequired(OracleDataReader reader, Enum fieldName)
        {
            return GetDoubleRequired(reader, fieldName.ToString());
        }

        public static long? GetLong(OracleDataReader reader, string fieldName)
        {
            // Get the field index
            int fieldIndex = reader.GetOrdinal(fieldName);

            // Check if the field is null
            if (reader.IsDBNull(fieldIndex))
            {
                return null;
            }

            // Return the field value
            return reader.GetInt64(fieldIndex);
        }

        public static long? GetLong(OracleDataReader reader, Enum fieldName)
        {
            return GetLong(reader, fieldName.ToString());
        }

        public static int? GetInt(OracleDataReader reader, string fieldName)
        {
            // Get the field index
            int fieldIndex = reader.GetOrdinal(fieldName);

            // Check if the field is null
            if (reader.IsDBNull(fieldIndex))
            {
                return null;
            }

            // Return the field value
            return reader.GetInt32(fieldIndex);
        }

        public static int? GetInt(OracleDataReader reader, Enum fieldName)
        {
            return GetInt(reader, fieldName.ToString());
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "int", Justification = "It is required in this case.")]
        public static int GetIntRequired(OracleDataReader reader, string fieldName)
        {
            // Get the field index
            int fieldIndex = reader.GetOrdinal(fieldName);

            // Return the field value
            return reader.GetInt32(fieldIndex);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "int", Justification = "It is required in this case.")]
        public static int GetIntRequired(OracleDataReader reader, Enum fieldName)
        {

            return GetIntRequired(reader, fieldName.ToString());
        }

        public static DateTime? GetDateTime(OracleDataReader reader, string fieldName)
        {
            // Get the field index
            int fieldIndex = reader.GetOrdinal(fieldName);

            // Check if the field is null
            if (reader.IsDBNull(fieldIndex))
            {
                return null;
            }

            // Return the field value
            return reader.GetDateTime(fieldIndex);
        }

        public static DateTime? GetDateTime(OracleDataReader reader, Enum fieldName)
        {
            return GetDateTime(reader, fieldName.ToString());
        }

        public static byte GetByteRequired(OracleDataReader reader, Enum fieldName)
        {
            return GetByteRequired(reader, fieldName.ToString());
        }

        public static byte GetByteRequired(OracleDataReader reader, string fieldName)
        {
            // Get the field index
            int fieldIndex = reader.GetOrdinal(fieldName);

            // Return the field value
            return reader.GetByte(fieldIndex);
        }

        public static byte? GetByte(OracleDataReader reader, Enum fieldName)
        {
            return GetByte(reader, fieldName.ToString());
        }

        public static byte? GetByte(OracleDataReader reader, string fieldName)
        {
            int fieldIndex = reader.GetOrdinal(fieldName);

            if (reader.IsDBNull(fieldIndex))
            {
                return null;
            }

            return reader.GetByte(fieldIndex);
        }

        public static bool? GetBoolean(OracleDataReader oracleDataReader, Enum fieldName)
        {
            return GetBoolean(oracleDataReader, fieldName.ToString());
        }

        public static bool? GetBoolean(OracleDataReader oracleDataReader, string fieldName)
        {
            int fieldIndex = oracleDataReader.GetOrdinal(fieldName);

            if (oracleDataReader.IsDBNull(fieldIndex))
            {
                return null;
            }

            return ParseNullableBoolean(oracleDataReader.GetInt32(fieldIndex));
        }

        public static string GetString(OracleDataReader reader, string fieldName)
        {
            // Get the field index
            int fieldIndex = reader.GetOrdinal(fieldName);

            // Check if the field is null
            if (reader.IsDBNull(fieldIndex))
            {
                return null;
            }

            // Return the field value
            return reader.GetString(fieldIndex);
        }

        public static string GetString(OracleDataReader reader, Enum fieldName)
        {
            return GetString(reader, fieldName.ToString());
        }

        public static QueryData BuildQuery(string queryBase, Enum parameterName, List<string> parameters, DbType dbType)
        {
            return BuildQuery(queryBase, parameterName, parameters, dbType, CnstQueryParameterPrefix);
        }

        /// <summary>
        /// Builds the query.
        /// </summary>
        /// <param name="queryBase">The query base.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="dbType">Type of the database.</param>
        /// <param name="replaceParameterName">Name of the replace parameter.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// parameterName
        /// or
        /// queryBase
        /// or
        /// parameters
        /// </exception>
        /// <exception cref="System.ArgumentNullException">queryBase
        /// or
        /// parameters</exception>
        public static QueryData BuildQuery(string queryBase, Enum parameterName, List<string> parameters, DbType dbType, string replaceParameterName)
        {
            if (parameterName == null)
            {
                throw new ArgumentNullException("parameterName");
            }

            if (queryBase == null)
            {
                throw new ArgumentNullException("queryBase");
            }

            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }

            if (!parameters.Any())
            {
                return new QueryData(queryBase);
            }

            List<OracleParameter> queryParameters = new List<OracleParameter>();
            string query = queryBase;

            int index = 0;

            // For each non empty parameter value create OracleParameter with the following naming scheme: @Param + Index
            foreach (string loopParameter in parameters.Where(item => !string.IsNullOrEmpty(item)))
            {
                string newParameterName = replaceParameterName + index.ToString(CultureInfo.InvariantCulture);

                OracleParameter oracleParameter = new OracleParameter();
                oracleParameter.DbType = dbType;
                oracleParameter.ParameterName = newParameterName;
                oracleParameter.Value = loopParameter;

                queryParameters.Add(oracleParameter);
                index++;
            }

            if (queryParameters.Any())
            {
                // If there were any parameters created, join the parameters into a single string value: "@Param0, @Param1, @Param2, ...".
                string parametersString = string.Join(", ", queryParameters.Select(item => ":" + item.ParameterName).ToArray());

                // Replace the parameter in the query with name parameterName with the generated parametersString.
                query = queryBase.Replace(":" + parameterName, parametersString);
            }

            // Return the modified query data
            QueryData queryData = new QueryData(query);
            queryData.Parameters.AddRange(queryParameters);
            return queryData;
        }

        public static QueryData BuildQuery<T>(string queryBase, Enum parameterName, ICollection<T> parameters, DbType dbType, string replaceParameterName)
        {
            if (parameterName == null)
            {
                throw new ArgumentNullException("parameterName");
            }

            if (queryBase == null)
            {
                throw new ArgumentNullException("queryBase");
            }

            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }

            if (!parameters.Any())
            {
                return new QueryData(queryBase);
            }

            List<OracleParameter> queryParameters = new List<OracleParameter>();
            string query = queryBase;

            int index = 0;

            // For each non empty parameter value create OracleParameter with the following naming scheme: @Param + Index
            foreach (var loopParameter in parameters)
            {
                string newParameterName = replaceParameterName + index.ToString(CultureInfo.InvariantCulture);

                OracleParameter oracleParameter = new OracleParameter();
                oracleParameter.DbType = dbType;
                oracleParameter.ParameterName = newParameterName;
                oracleParameter.Value = loopParameter;

                queryParameters.Add(oracleParameter);
                index++;
            }

            if (queryParameters.Any())
            {
                // If there were any parameters created, join the parameters into a single string value: "@Param0, @Param1, @Param2, ...".
                string parametersString = string.Join(", ", queryParameters.Select(item => ":" + item.ParameterName).ToArray());

                // Replace the parameter in the query with name parameterName with the generated parametersString.
                query = queryBase.Replace(":" + parameterName, parametersString);
            }

            // Return the modified query data
            QueryData queryData = new QueryData(query);
            queryData.Parameters.AddRange(queryParameters);
            return queryData;
        }

        public static TEnum? ParseNullableEnum<TEnum>(object value)
            where TEnum : struct
        {
            if (value == null)
            {
                return null;
            }

            TEnum parsedValue;

            if (Enum.TryParse(value.ToString(), true, out parsedValue))
            {
                return parsedValue;
            }
            else
            {
                return null;
            }
        }

        public static bool? ParseNullableBoolean(long? value)
        {
            if (value == null)
            {
                return null;
            }

            return Convert.ToBoolean(value.Value, CultureInfo.InvariantCulture);
        }

        public static long? NullableToLong(bool? value)
        {
            if (value == null)
            {
                return null;
            }

            return Convert.ToInt64(value.Value, CultureInfo.InvariantCulture);
        }

        public static string NullableToStringNumber<T>(T? value)
            where T : struct
        {
            if (value == null)
            {
                return null;
            }

            long longValue = Convert.ToInt64(value.Value, CultureInfo.InvariantCulture);

            return longValue.ToString(CultureInfo.InvariantCulture);
        }

        public static string NullableToString(long? value)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                return value.Value.ToString(CultureInfo.InvariantCulture);
            }
        }

        public static long? ParseNullableLong(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            long output;

            if (long.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out output))
            {
                return output;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the field value as specified type. If the data does not match the desired type, the default value is taken.
        /// </summary>
        /// <typeparam name="T">Type of the returned value.</typeparam>
        /// <param name="reader">Oracle data reader.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns></returns>
        public static T GetValueOrDefault<T>(OracleDataReader reader, string fieldName)
        {
            if (reader == null) throw new ArgumentNullException(nameof(reader));

            try
            {
                return (T)reader[fieldName];
            }
            catch (InvalidCastException)
            {
                return default(T);
            }
        }
        #endregion
    }
}
