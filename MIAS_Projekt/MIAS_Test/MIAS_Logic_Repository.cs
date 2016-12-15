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
            DbConnection connection = new DbConnection();
            var reulst =connection.RunQuery("select country_name from countries");
        }
    }
}
