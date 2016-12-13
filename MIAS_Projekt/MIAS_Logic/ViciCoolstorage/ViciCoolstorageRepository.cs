using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_Logic.ViciCoolstorage
{
    public class ViciCoolstorageRepository
    {
        public CSGenericRecordList SelectData(string selectCommand,string context)
        {
            return CSDatabase.Context[context].RunQuery(selectCommand);
        }
    }
}
