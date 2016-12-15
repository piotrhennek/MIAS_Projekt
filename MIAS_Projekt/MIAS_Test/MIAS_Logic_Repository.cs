using MIAS_Logic.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Test
{
    [TestClass]
    public class MIAS_Logic_Repository
    {
        [TestMethod]
        public void OracleRepoTest()
        {
            OracleDbConnection connection = new OracleDbConnection();
            var result =connection.RunQuery("select country_name from countries");
        }

        [TestMethod]
        public void SqlRepoTest()
        {
            SqlDbConnection connection = new SqlDbConnection();
            var result = connection.RunQuery("select country_name from countries");
        }
    }
}
