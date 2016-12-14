using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MIAS_Logic.ViciCoolstorage;
using MIAS_Logic;
//https://github.com/viciproject/coolstorage/tree/master/drivers/oracle
//https://searchcode.com/codesearch/view/46434162/#
//https://books.google.pl/books?id=_j1xmsV-OWAC&pg=PA403&lpg=PA403&dq=c%23+vici+coolstorage&source=bl&ots=S_QHvazBZ4&sig=aUEx8FuJXpGlyTmhz8UFtMyoe4c&hl=pl&sa=X&sqi=2&ved=0ahUKEwjWxZv75OzQAhVJbhQKHfugCxEQ6AEINjAD#v=onepage&q=c%23%20vici%20coolstorage&f=false

namespace MIAS_Test
{
    [TestClass]
    public class MIAS_Logic_CoolStorage
    {
        private const string sqlConnectionString = "Initial Catalog=mias;Data Source=localhost;User ID=test;PWD=test;";
        private const string selectCommad = "select country_id from countries";
        private const string oracleConnectionString = "User Id=s85137;Password=malybaza;Data Source=(DESCRIPTION=" +
  "(ADDRESS=(PROTOCOL=TCP)(HOST=217.173.198.136)(PORT=1522))" +
  "(CONNECT_DATA=(SID=orclwh)));";
        private ViciCoolstorageRepository repo;

        [TestMethod]

        public void SelectData()
        {
            repo = new ViciCoolstorageRepository();
            DB.InitSQLDB(sqlConnectionString);
            var test =repo.SelectData(selectCommad,DB.SQLCONTEXT);
        }

        [TestMethod]
        public void OracleTest()
        {
            var oracleRepo = new ViciCoolstorageRepository();
            DB.InitOracleDB(oracleConnectionString);
            var test =oracleRepo.SelectData(selectCommad, DB.ORACLECONTEXT);
        }

        [TestMethod]
        public void SqlAndOracleViciCoolstorageTest()
        {
            var logic = new RepositoriesLogic();
            logic.Query = selectCommad;
            logic.RunViciCoolStorageQueries();
            var times = logic.GetQueriesTimes();
        }

    }
}
