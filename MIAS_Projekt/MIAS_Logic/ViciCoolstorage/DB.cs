using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_Logic.ViciCoolstorage
{
    public static class DB
    {
        public const string CONTEXT = "mias";

        public static void InitSQLDB(string connectionString, string context)
        {
            CSConfig.SetDB(new CSDataProviderSqlServer(connectionString), context);
        }

        public static void InitOracleDB(string connectionString, string context)
        {
            CSConfig.SetDB(new CSDataProviderOracle(connectionString), context);
            var test = CSDatabase.Context["s85137"];
        }
    }
}
