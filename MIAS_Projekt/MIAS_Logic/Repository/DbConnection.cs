﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic.Repository
{
    public class DbConnection
    {
        private OracleConnection connection { get; set;}

        public DbConnection()
        {
            connection = new OracleConnection(DatabasesConfig.OracleConnectionString);
        }

        private void Connect()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }

        public int RunQuery(string query)
        {
      
            Connect();
            var cmd = connection.CreateCommand();
            cmd.CommandText = query;
            var adapter = new OracleDataAdapter(cmd);
            OracleDataReader reader = adapter.SelectCommand.ExecuteReader();
         
            return GetRowsCount(reader);
        }

        private int GetRowsCount(OracleDataReader reader)
        {
            int counter = 0;
            while (reader.Read())
            {
                counter++;
            }
            return counter;
        }
    }
}
