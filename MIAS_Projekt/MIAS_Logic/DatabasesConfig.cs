﻿using MIAS_Logic.ViciCoolstorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_Logic
{
    public static class DatabasesConfig
    {
        public const string EntityFrameworkSqlName = "name=SqlServerConnectionString";
        public const string EntityFrameworkOracleName = "name=SqlServerConnectionString";

        public const string SqlConnectionString = @"Server=PEDRO\INSOFT2014;Database=test;Trusted_Connection=True;";
        public const string OracleConnectionString = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 217.173.198.136)(PORT = 1522))(CONNECT_DATA =(SERVER=DEDICATED)(SID = orclwh)));User Id=s84038;Password=student_s84038;";

        public const string SQLCONTEXT = "mias";
        public const string ORACLECONTEXT = "s84038";


        public static void InitViciSQLDB()
        {
            CSConfig.SetDB(new CSDataProviderSqlServer(SqlConnectionString), SQLCONTEXT);
        }

        public static void InitViciOracleDB()
        {
            CSConfig.SetDB(new CSDataProviderOracle(OracleConnectionString), ORACLECONTEXT);
        }
    }
}
