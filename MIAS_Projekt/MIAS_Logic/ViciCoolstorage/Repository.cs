using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_Logic.ViciCoolstorage
{
    public class Repository
    {
        public CSGenericRecordList SelectData(string selectCommand)
        {
            return CSDatabase.Context[DB.CONTEXT].RunQuery(selectCommand);
        }
    }
}
