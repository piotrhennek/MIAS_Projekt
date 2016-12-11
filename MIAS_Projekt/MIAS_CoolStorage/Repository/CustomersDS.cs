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
        //public CustomersModel Get(int id)
        //{
        //    return CustomersModel.Read(id);
        //}

        //public void TEST()
        //{
           
        //}
        public string[] GetSurnames()
        {
            var resut = CSDatabase.Context[DB.CONTEXT].RunQuery("select CustomerSurname from Customers");
            return new string[2];
        }
    }
}
