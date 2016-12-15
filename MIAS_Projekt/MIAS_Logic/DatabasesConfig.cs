using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic
{
    public static class DatabasesConfig
    {
        public const string EntityFrameworkSqlName = "name=SqlServerConnectionString";
        public const string EntityFrameworkOracleName = "name=OracleServerConnectionString";

        public const string SqlConnectionString = "Initial Catalog=mias;Data Source=localhost;User ID=test;PWD=test;";
        public const string OracleConnectionString = "User Id=s85137;Password=malybaza;Data Source=(DESCRIPTION=" +
  "(ADDRESS=(PROTOCOL=TCP)(HOST=217.173.198.136)(PORT=1522))" +
  "(CONNECT_DATA=(SID=orclwh)));";
    }
}
