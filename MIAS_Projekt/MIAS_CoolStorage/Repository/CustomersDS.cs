using MIAS_CoolStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_CoolStorage.Repository
{
    public class CustomersDS
    {
        //}
        public CSGenericRecordList SelectDataByViciCoolStorage(string selectSql)
        {
            return CSDatabase.Context[DB.CONTEXT].RunQuery(selectSql);
        }
    }
}
