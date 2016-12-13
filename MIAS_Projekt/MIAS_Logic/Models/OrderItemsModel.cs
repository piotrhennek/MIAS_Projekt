using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic
{
    class OrderItemsModel : ModelBase
    {
        public virtual double UnitPrice { get; set; }
        public virtual int Quantity { get; set; }
    }
}
