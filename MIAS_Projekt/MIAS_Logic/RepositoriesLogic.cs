using MIAS_Logic.EntityFramework;
using MIAS_Logic.Repository;
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
        public int resultCount;

        public RepositoriesLogic()
        {
            queriesTimeDictionary = new Dictionary<DatabasesEnum, string[]>();
            //DB.InitOracleDB(DatabasesConfig.OracleConnectionString);
            //DB.InitSQLDB(DatabasesConfig.SqlConnectionString);
        }
        
        public void RunViciCoolStorageQueries()
        {
         //   RunViciCoolStorageSqlQuery();
            RunViciCoolStorageOracleQuery();
        }
        public void RunEntityFrameworkQueries()
        {
            RunEntityFrameworkSqlQuery();
            try{
                RunEntityFrameworkOracleQuery();
            }
            catch(Exception exc)
            {
                Trace.WriteLine($"OracleEntityFrameworkExc: {exc.Message}");
            }
            
        }

        public void RunRepositoryQueries()
        {
        //    RunRepoSqlQuery();
            RunRepoOracleQuery();
        }

        private void RunEntityFrameworkSqlQuery()
        {
            Trace.WriteLine("EntityFramework Sql Method");
            int count = 0;

            Stopwatch stw = new Stopwatch();
            stw.Start();
            using (DbContext context = new MIASDbContext(DatabasesConfig.EntityFrameworkSqlName))
            {
                resultCount = context.Database.SqlQuery<object>(Query).Count();
            }
            stw.Stop();
            queriesTimeDictionary.Add(DatabasesEnum.EntityFrameworkSql, 
                new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{resultCount}rows" });
        }
        private void RunEntityFrameworkOracleQuery()
        {
            Trace.WriteLine("EntityFramework Oracle Method");
            int count = 0;

            Stopwatch stw = new Stopwatch();
            stw.Start();
            try
            {
                using (DbContext context = new MIASDbContext(DatabasesConfig.EntityFrameworkOracleName))
                {
                    count = context.Database.SqlQuery<object>(Query).Count();
                }
                stw.Stop();
                queriesTimeDictionary.Add(DatabasesEnum.EntityFrameworkOracle,
                    new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{count}rows" });
            }
            catch
            {

                stw.Stop();
                queriesTimeDictionary.Add(DatabasesEnum.EntityFrameworkOracle,
                    new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{resultCount}rows" });
            }
        }


        public IDictionary<DatabasesEnum, string[]> GetQueriesTimes()
        {
            return queriesTimeDictionary;
        }

        private void RunViciCoolStorageSqlQuery()
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            DatabasesConfig.InitViciSQLDB();
            var result= CSDatabase.Context[DatabasesConfig.SQLCONTEXT].RunQuery(Query);
            stw.Stop();
            queriesTimeDictionary.Add(DatabasesEnum.ViciSql, new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{result.Count}rows" });
        }

        private void RunViciCoolStorageOracleQuery()
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            DatabasesConfig.InitViciOracleDB();
            var result=CSDatabase.Context[DatabasesConfig.ORACLECONTEXT].RunQuery(Query);
            stw.Stop();
            queriesTimeDictionary.Add(DatabasesEnum.ViciOracle, new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{result.Count}rows" });
        }

        private void RunRepoSqlQuery()
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            var count = new SqlDbConnection().RunQuery(Query);
            stw.Stop();
            queriesTimeDictionary.Add(DatabasesEnum.RepositorySql, new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{count}rows" });
        }

        private void RunRepoOracleQuery()
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            var count = new OracleDbConnection().RunQuery(Query);
            stw.Stop();
            queriesTimeDictionary.Add(DatabasesEnum.RepositoryOracle, new string[2] { $"{stw.ElapsedMilliseconds}ms", $"{count}rows" });
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
