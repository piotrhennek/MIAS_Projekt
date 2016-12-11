using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;
using System.ComponentModel;
namespace MIAS_CoolStorage.Models
{
    [MapTo("Customers",DB.CONTEXT)]
    public abstract class CustomersModel : CSObject<CustomersModel, int>
    {
        public abstract int IdCustomer {get;set;}
        public abstract string CustomerName { get; set; }
        public abstract string CustomerSurname { get; set; }
    }
}
