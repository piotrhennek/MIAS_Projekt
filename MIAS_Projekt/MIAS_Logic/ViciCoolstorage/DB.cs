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
        public const string SQLCONTEXT = "mias";
        public const string ORACLECONTEXT = "s85137";

        public static void InitSQLDB(string connectionString)
        {
            CSConfig.SetDB(new CSDataProviderSqlServer(connectionString), SQLCONTEXT);
        }

        public static void InitOracleDB(string connectionString)
        {
            CSConfig.SetDB(new CSDataProviderOracle(connectionString), ORACLECONTEXT);
        }
    }
}
