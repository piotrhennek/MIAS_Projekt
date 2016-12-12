using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic
{
    public class ProductInformationModel : ModelBase
    {
        public virtual string ProductName { get; set; }
        public virtual string Description { get; set; }
        public virtual int WeightClass { get; set; }
        public virtual string ProductStatus { get; set; }

    }
}
