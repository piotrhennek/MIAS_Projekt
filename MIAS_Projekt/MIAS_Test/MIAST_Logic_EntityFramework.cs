using MIAS_Logic.EntityFramework;
using MIAS_Logic.ViciCoolstorage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;

namespace MIAS_Test
{
    [TestClass]
    public class MIAST_Logic_EntityFramework
    {
        private const string sqlConnectionString = @"Data Source =localhost; Initial Catalog = mias; Persist Security Info=True;User ID =test; Password=test";
        private const string selectCommad = "select country_id from countries";
        [TestMethod]
        public void SqlEFTest()
        {

            //var efContext = new MIASDbContext(sqlConnectionString);
            using(DbContext context = new MIASDbContext(sqlConnectionString))
            {
                 var test =context.Database.SqlQuery<object>("select country_name, country_id from countries");
            }
        }

    }
}
