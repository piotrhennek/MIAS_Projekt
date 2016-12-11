using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_CoolStorage.Connection
{
    class CSSqlConnection : ICSDbConnection
    {
        public readonly SqlConnection Connection;
        public CSSqlConnection(SqlConnection connection)
        {
            Connection = connection;
        }
        public ICSDbTransaction BeginTransaction()
        {
            return new CSSqlTransaction(Connection.BeginTransaction());
        }

        public ICSDbTransaction BeginTransaction(IsolationLevel isolationLevel)
        {
            return new CSSqlTransaction(Connection.BeginTransaction(isolationLevel));
        }

        public void Close()
        {
            Connection.Close();
        }

        public ICSDbCommand CreateCommand()
        {
            return new CSSqlCommand(Connection.CreateCommand());
        }

        public void Dispose()
        {
            Connection.Dispose();
        }

        public bool IsClosed()
        {
            return Connection.State == ConnectionState.Closed;
        }

        public bool IsOpenAndReady()
        {
            return Connection.State == ConnectionState.Open;
        }
    }
}
