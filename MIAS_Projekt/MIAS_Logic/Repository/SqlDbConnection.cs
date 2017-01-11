using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
        public List<long> RunQuery(string query, int replies)
        {
            Connect();
            var cmd = connection.CreateCommand();
            cmd.CommandText = query;
            var adapter = new SqlDataAdapter(cmd);
      //      SqlDataReader reader = adapter.SelectCommand.ExecuteReader();
            var result = new Dictionary<string, object>();
            var listOfResults = new List<Dictionary<string, object>>();
            var listOfElapsedMilliseconds = new List<long>();

            for (int i = 0; i < replies; i++)
            {
                Stopwatch stw = new Stopwatch();
                stw.Start();
                using (var reader = adapter.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int lp = 0; lp < reader.FieldCount; lp++)
                        {
                            result.Add(reader.GetName(lp), reader.GetValue(lp));
                        }
                        listOfResults.Add(result);
                        result.Clear();
                    }
                }
                stw.Stop();
                listOfElapsedMilliseconds.Add(stw.ElapsedMilliseconds);
            }
            return listOfElapsedMilliseconds;
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
