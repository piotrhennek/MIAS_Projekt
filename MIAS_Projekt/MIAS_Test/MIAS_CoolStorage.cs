using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MIAS_CoolStorage.Models;
using MIAS_CoolStorage;
using MIAS_CoolStorage.Connection;
//https://github.com/viciproject/coolstorage/tree/master/drivers/oracle
//https://searchcode.com/codesearch/view/46434162/#
//https://books.google.pl/books?id=_j1xmsV-OWAC&pg=PA403&lpg=PA403&dq=c%23+vici+coolstorage&source=bl&ots=S_QHvazBZ4&sig=aUEx8FuJXpGlyTmhz8UFtMyoe4c&hl=pl&sa=X&sqi=2&ved=0ahUKEwjWxZv75OzQAhVJbhQKHfugCxEQ6AEINjAD#v=onepage&q=c%23%20vici%20coolstorage&f=false

namespace MIAS_Test
{
    [TestClass]
    public class MIAS_CoolStorage
    {
        [TestMethod]

        public void SetupServer()
        {
            CSDataProviderSqlServer server = new CSDataProviderSqlServer("Initial Catalog=mias;Data Source=localhost;User ID=test;PWD=test;");
            
        }
        [TestMethod]
        public void RetrieveDataFromCustomersTest()
        {
        }
    }
}
