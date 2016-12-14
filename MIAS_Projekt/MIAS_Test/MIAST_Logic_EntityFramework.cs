using MIAS_Logic.EntityFramework;
using MIAS_Logic.ViciCoolstorage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MIAS_Test
{
    [TestClass]
    public class MIAST_Logic_EntityFramework
    {
        //private const string sqlConnectionString = @"Data Source =localhost; Initial Catalog = mias; Persist Security Info=True;User ID =test; Password=test";
        //private const string selectCommad = "select country_id from countries";
        //[TestMethod]
        //public async Task<int> SqlEFTest()
        //{
        //    int count = 0;

        //    //var efContext = new MIASDbContext(sqlConnectionString);
        //    using (DbContext context = new MIASDbContext(sqlConnectionString))
        //    {
        //        var test = context.Database.SqlQuery<object>("select country_name, country_id from countries");
        //        count = await test.CountAsync();
        //    }
        //    return count;
        //}

        //[TestMethod]
        //public void Test()
        //{
        //    var a=SqlEFTest();
        //}

    }
}
