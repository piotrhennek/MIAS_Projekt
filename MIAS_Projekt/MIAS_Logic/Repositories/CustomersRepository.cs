using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace MIAS_Logic
{
    public class CustomersRepository : BaseRepository, ICustomersRepository
    {
        private const string ConstQueryGetAll = @"SELECT
                                                    CUSTOMER_ID,
                                                    CUST_FIRST_NAME,
                                                    CUST_LAST_NAME
                                                  FROM CUSTOMERS;";
        public CustomersRepository(OracleConnection connection)
            : base(connection)
        {
        }

        private enum QueryParameters
        {
            CUSTOMER_ID,
            CUST_FIRST_NAME,
            CUST_LAST_NAME
        }

        public CustomersModel CreateNew()
        {
            return new CustomersModel();
        }

        public List<CustomersModel> GetAll()
        {
            try
            {
                using (var command = this.CreateCommand(ConstQueryGetAll))
                {
                    using (OracleDataReader reader = this.ExecuteReader(command))
                    {
                        var result = new List<CustomersModel>();
                        while (reader.Read())
                        {
                            result.Add(this.MyParseModel(reader));
                        }

                        return result;
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message, exception);
            }
        }
        #region My methods
        private CustomersModel MyParseModel(OracleDataReader reader)
        {
            var model = this.CreateNew();
            model.CustFirstName = OracleHelper.GetString(reader, QueryParameters.CUST_FIRST_NAME);
            model.CustLastName = OracleHelper.GetString(reader, QueryParameters.CUST_LAST_NAME);
            model.Id = OracleHelper.GetInt(reader, QueryParameters.CUSTOMER_ID);
            return model;
        }
        #endregion
    }
}
