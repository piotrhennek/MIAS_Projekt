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
        public int Replies { get; set; }

        private IDictionary<DatabasesEnum, string> queriesTimeDictionary { get; set; }
        private MultiValueDictionary<string,string> queriesTimesMultiDictionary { get; set; }
        public int resultCount;

        public RepositoriesLogic()
        {
            queriesTimeDictionary = new Dictionary<DatabasesEnum, string>();
            queriesTimesMultiDictionary = new MultiValueDictionary<string, string>();
            //DB.InitOracleDB(DatabasesConfig.OracleConnectionString);
            //DB.InitSQLDB(DatabasesConfig.SqlConnectionString);
        }

        public void RunViciCoolStorageQueries()
        {
            RunViciCoolStorageSqlQuery();
            RunViciCoolStorageOracleQuery();
        }
        public void RunEntityFrameworkQueries()
        {
            RunEntityFrameworkSqlQuery();
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
            RunRepoSqlQuery();
            RunRepoOracleQuery();
        }

        public void RunEntityFrameworkSqlQuery()
        {
            Trace.WriteLine("EntityFramework Sql Method");
            var listOfResults = new List<List<QueryResult>>();
            var listOfElapsedMilliseconds = new List<long>();
            using (DbContext context = new MIASDbContext(DatabasesConfig.EntityFrameworkSqlName))
            {
                for (int i = 1; i <= Replies; i++)
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
            AddToDictionary(DatabasesEnum.EntityFrameworkSql, listOfElapsedMilliseconds);

        }
        public void RunEntityFrameworkOracleQuery()
        {
            Trace.WriteLine("EntityFramework Oracle Method");

            var listOfResults = new List<List<QueryResult>>();
            var listOfElapsedMilliseconds = new List<long>();
            Stopwatch stwatch = new Stopwatch();
            stwatch.Start();
            try
            {
                using (DbContext context = new MIASDbContext("data source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 217.173.198.136)(PORT = 1522))(CONNECT_DATA = (SID = orclwh))); user id = s85137; password = malybaza;"))
                {

                    for (int i = 1; i <= Replies; i++)
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
            catch(Exception ex)
            {
                //queriesTimeDictionary.Add(DatabasesEnum.EntityFrameworkOracle, $"{listOfElapsedMilliseconds.Average()}");
                //AddToDictionary(DatabasesEnum.EntityFrameworkOracle, listOfElapsedMilliseconds);

            }
        }


        public IDictionary<DatabasesEnum, string> GetQueriesTimes()
        {
            return queriesTimeDictionary;
        }

        public void RunViciCoolStorageSqlQuery()
        {
            DatabasesConfig.InitViciSQLDB();
            List<CSGenericRecordList> listOfResults = new List<CSGenericRecordList>();
            var listOfElapsedMilliseconds = new List<long>();
            for (int i = 0; i <= Replies; i++)
            {
                Stopwatch stw = new Stopwatch();

                stw.Start();
                listOfResults.Add(CSDatabase.Context[DatabasesConfig.SQLCONTEXT].RunQuery(Query));
                stw.Stop();
                listOfElapsedMilliseconds.Add(stw.ElapsedMilliseconds);
            }
            queriesTimeDictionary.Add(DatabasesEnum.ViciSql, $"{listOfElapsedMilliseconds.Average()}");
            AddToDictionary(DatabasesEnum.ViciSql, listOfElapsedMilliseconds);

        }

        public void RunViciCoolStorageOracleQuery()
        {
            DatabasesConfig.InitViciOracleDB();
            List<CSGenericRecordList> listOfResults = new List<CSGenericRecordList>();
            var listOfElapsedMilliseconds = new List<long>();
            for (int i = 0; i <= Replies; i++)
            {
                Stopwatch stw = new Stopwatch();

                stw.Start();
                listOfResults.Add(CSDatabase.Context[DatabasesConfig.ORACLECONTEXT].RunQuery(Query));
                stw.Stop();
                listOfElapsedMilliseconds.Add(stw.ElapsedMilliseconds);
            }

            queriesTimeDictionary.Add(DatabasesEnum.ViciOracle, $"{listOfElapsedMilliseconds.Average()}");
            AddToDictionary(DatabasesEnum.ViciOracle, listOfElapsedMilliseconds);

        }

        public void RunRepoSqlQuery()
        {
            var listOfElapsedMiliseconds = new SqlDbConnection().RunQuery(Query, Replies);
            queriesTimeDictionary.Add(DatabasesEnum.RepositorySql, $"{listOfElapsedMiliseconds.Average()}");
            AddToDictionary(DatabasesEnum.RepositorySql, listOfElapsedMiliseconds);

        }

        public void RunRepoOracleQuery()
        {
            var listOfElapsedMiliseconds = new OracleDbConnection().RunQuery(Query, Replies);
            queriesTimeDictionary.Add(DatabasesEnum.RepositoryOracle, $"{listOfElapsedMiliseconds.Average()}");
            AddToDictionary(DatabasesEnum.RepositoryOracle, listOfElapsedMiliseconds);
        }

        public void LogData()
        {
          //  var logger = new DataLogger();
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, IReadOnlyCollection<string>> key in queriesTimesMultiDictionary)
            {
                foreach (var value in key.Value)
                {
                    sb.AppendLine($"{Query},{key.Key},{value}");
                }
            }
            DataLogger.Log(sb);
            queriesTimeDictionary.Clear();
            queriesTimesMultiDictionary.Clear();
        }
        public void AddToDictionary(DatabasesEnum dbe, List<long> elapsedMs)
        {
            foreach (var elapsedMilisecond in elapsedMs)
            {
                queriesTimesMultiDictionary.Add(dbe.ToString(), elapsedMilisecond.ToString());
            }
            queriesTimesMultiDictionary.Add("", "");
        }

    }
}
