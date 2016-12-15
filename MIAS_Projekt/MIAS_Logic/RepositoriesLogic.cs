using MIAS_Logic.EntityFramework;
using MIAS_Logic.ViciCoolstorage;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_Logic
{
    public class RepositoriesLogic
    {
       
        public string Query { get; set; }
        private IDictionary<DatabasesEnum, string[]> queriesTimeDictionary { get; set; }

        public RepositoriesLogic()
        {
            queriesTimeDictionary = new Dictionary<DatabasesEnum, string[]>();
            DB.InitOracleDB(DatabasesConfig.OracleConnectionString);
            DB.InitSQLDB(DatabasesConfig.SqlConnectionString);
        }
        
        public void RunViciCoolStorageQueries()
        {
            RunViciCoolStorageSqlQuery();
            RunViciCoolStorageOracleQuery();
        }
        public void RunEntityFrameworkQueries()
        {
            RunEntityFrameworkSqlQuery();
            RunEntityFrameworkOracleQuery();
        }

        private void RunEntityFrameworkSqlQuery()
        {
            Trace.WriteLine("EntityFramework Method");
            int count = 0;

            Stopwatch stw = new Stopwatch();
            stw.Start();
            using (DbContext context = new MIASDbContext(DatabasesConfig.EntityFrameworkSqlName))
            {
                count=context.Database.SqlQuery<object>(Query).Count();
            }
            stw.Stop();
            queriesTimeDictionary.Add(DatabasesEnum.EntityFrameworkSql, 
                new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{count}rows" });
        }
        private void RunEntityFrameworkOracleQuery()
        {
            Trace.WriteLine("EntityFramework Method");
            int count = 0;

            Stopwatch stw = new Stopwatch();
            stw.Start();
            using (DbContext context = new MIASDbContext(DatabasesConfig.EntityFrameworkOracleName))
            {
                count = context.Database.SqlQuery<object>(Query).Count();
            }
            stw.Stop();
            queriesTimeDictionary.Add(DatabasesEnum.EntityFrameworkOracle,
                new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{count}rows" });
        }


        public IDictionary<DatabasesEnum, string[]> GetQueriesTimes()
        {
            return queriesTimeDictionary;
        }

        private void RunViciCoolStorageSqlQuery()
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            var result= CSDatabase.Context[DB.SQLCONTEXT].RunQuery(Query);
            stw.Stop();
            queriesTimeDictionary.Add(DatabasesEnum.ViciSql, new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{result.Count}rows" });
        }

        private void RunViciCoolStorageOracleQuery()
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            var result=CSDatabase.Context[DB.ORACLECONTEXT].RunQuery(Query);
            stw.Stop();
            queriesTimeDictionary.Add(DatabasesEnum.ViciOracle, new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{result.Count}rows" });
        }

        public void LogData()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in queriesTimeDictionary)
            {
                sb.AppendLine($"{Query},{item.Key},{item.Value[0]},{item.Value[1]}");
            }
            DataLogger.Log(sb);
            queriesTimeDictionary.Clear();
        }


    }
}
