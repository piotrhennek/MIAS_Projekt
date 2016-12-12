using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic
{
    public class ProductDescriptionModel : ModelBase
    {
        public virtual string TranslatedName { get; set; }
        public virtual string TranslatedDescription { get; set; }
    }
}
