using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic
{
    public class WarehousesModel : ModelBase
    {
        public virtual string WarehouseName { get; set; }
        public virtual string WarehouseSpec { get; set; }
    }
}
