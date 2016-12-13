using MIAS_Logic.EntityFramework;
using MIAS_Logic.ViciCoolstorage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MIAS_Test
{
    [TestClass]
    public class MIAST_Logic_EntityFramework
    {
        private const string sqlConnectionString = "Initial Catalog=mias;Data Source=localhost;User ID=test;PWD=test;";
        private const string selectCommad = "select country_id from countries";
        [TestMethod]
        public void SqlEFTest()
        {
            var efContext = new MIASDbContext(sqlConnectionString);
        }

    }
}
