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
    public class QueryResult
    {
        public string Key { get; set; }
        public object Value { get; set; }
    }
    public class RepositoriesLogic
    {

        public string Query { get; set; }
        private IDictionary<DatabasesEnum, string> queriesTimeDictionary { get; set; }
        public int resultCount;

        public RepositoriesLogic()
        {
            queriesTimeDictionary = new Dictionary<DatabasesEnum, string>();
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
            //   RunEntityFrameworkSqlQuery();
            try
            {
                RunEntityFrameworkOracleQuery();
            }
            catch (Exception exc)
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
            var listOfResults = new List<List<QueryResult>>();
            var listOfElapsedMilliseconds = new List<long>();
            using (DbContext context = new MIASDbContext(DatabasesConfig.EntityFrameworkSqlName))
            {
                for (int i = 1; i <= 100; i++)
                {
                    Stopwatch stw = new Stopwatch();
                    stw.Start();
                    var result = context.Database.SqlQuery<QueryResult>(Query).ToList();
                    stw.Stop();
                    listOfResults.Add(result);
                    listOfElapsedMilliseconds.Add(stw.ElapsedMilliseconds);
                }
            }
            queriesTimeDictionary.Add(DatabasesEnum.EntityFrameworkSql, $"{listOfElapsedMilliseconds.Average()}");
        }
        private void RunEntityFrameworkOracleQuery()
        {
            Trace.WriteLine("EntityFramework Oracle Method");

            var listOfResults = new List<List<QueryResult>>();
            var listOfElapsedMilliseconds = new List<long>();
            Stopwatch stwatch = new Stopwatch();
            stwatch.Start();
            try
            {
                using (DbContext context = new MIASDbContext(DatabasesConfig.EntityFrameworkOracleName))
                {

                    for (int i = 1; i <= 100; i++)
                    {
                        Stopwatch stw = new Stopwatch();
                        stw.Start();
                        stwatch.Stop();
                        listOfElapsedMilliseconds.Add(stwatch.ElapsedMilliseconds);
                        var result = context.Database.SqlQuery<QueryResult>(Query).ToList();
                        stw.Stop();
                        listOfResults.Add(result);
                        listOfElapsedMilliseconds.Add(stw.ElapsedMilliseconds);
                    }
                }
                queriesTimeDictionary.Add(DatabasesEnum.EntityFrameworkOracle, $"{listOfElapsedMilliseconds.Average()}");
            }
            catch
            {
                queriesTimeDictionary.Add(DatabasesEnum.EntityFrameworkOracle, $"{listOfElapsedMilliseconds.Average()}");
            }
        }


        public IDictionary<DatabasesEnum, string> GetQueriesTimes()
        {
            return queriesTimeDictionary;
        }

        private void RunViciCoolStorageSqlQuery()
        {
            DatabasesConfig.InitViciSQLDB();
            List<CSGenericRecordList> listOfResults = new List<CSGenericRecordList>();
            var listOfElapsedMilliseconds = new List<long>();
            for (int i = 0; i <= 100; i++)
            {
                Stopwatch stw = new Stopwatch();

                stw.Start();
                listOfResults.Add(CSDatabase.Context[DatabasesConfig.SQLCONTEXT].RunQuery(Query));
                stw.Stop();
                listOfElapsedMilliseconds.Add(stw.ElapsedMilliseconds);
            }
            queriesTimeDictionary.Add(DatabasesEnum.ViciSql, $"{listOfElapsedMilliseconds.Average()}");
        }

        private void RunViciCoolStorageOracleQuery()
        {
            DatabasesConfig.InitViciOracleDB();
            List<CSGenericRecordList> listOfResults = new List<CSGenericRecordList>();
            var listOfElapsedMilliseconds = new List<long>();
            for (int i = 0; i <= 100; i++)
            {
                Stopwatch stw = new Stopwatch();

                stw.Start();
                listOfResults.Add(CSDatabase.Context[DatabasesConfig.ORACLECONTEXT].RunQuery(Query));
                stw.Stop();
                listOfElapsedMilliseconds.Add(stw.ElapsedMilliseconds);
            }

            queriesTimeDictionary.Add(DatabasesEnum.ViciOracle, $"{listOfElapsedMilliseconds.Average()}");
        }

        private void RunRepoSqlQuery()
        {
            var listOfElapsedMiliseconds = new SqlDbConnection().RunQuery(Query);
            queriesTimeDictionary.Add(DatabasesEnum.RepositorySql, $"{listOfElapsedMiliseconds.Average()}");
        }

        private void RunRepoOracleQuery()
        {
            var listOfElapsedMiliseconds = new OracleDbConnection().RunQuery(Query);
            queriesTimeDictionary.Add(DatabasesEnum.RepositoryOracle, $"{listOfElapsedMiliseconds.Average()}");
        }

        public void LogData()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in queriesTimeDictionary)
            {
                sb.AppendLine($"{Query},{item.Key},{item.Value[0]},{item.Value[1]}");
            }
            DataLogger.Log(sb);
            queriesTimeDictionary.Clear();
        }


    }
}
