using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic
{
    public class OrdersModel : ModelBase
    {
        public virtual DateTime OrderDate { get; set; }
        public virtual string OrderMode { get; set; }
        public virtual int OrderStatus { get; set; }
    }
}
