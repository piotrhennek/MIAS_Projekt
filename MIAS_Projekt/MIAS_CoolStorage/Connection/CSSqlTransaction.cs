using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_CoolStorage.Connection
{
    class CSSqlTransaction : ICSDbTransaction
    {
        public readonly SqlTransaction Transaction;

        public CSSqlTransaction(SqlTransaction transaction)
        {
            Transaction = transaction;
        }

        public void Dispose()
        {
            Transaction.Dispose();
        }

        public void Commit()
        {
            Transaction.Commit();
        }

        public void Rollback()
        {
            Transaction.Rollback();
        }
    }
}
