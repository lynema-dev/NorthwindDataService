using System;
using System.Data.SqlClient;

namespace NorthwindDataService.Factories
{
    public class CustomerOrdersHistoryFactory : CustomerOrderHistory
    {
        private readonly INorthwindSqlDatabase _northwindSqlDatabase;

        public CustomerOrdersHistoryFactory(INorthwindSqlDatabase northwindSqlDatabase)
        {
            _northwindSqlDatabase = northwindSqlDatabase;
        }

        public CustomerOrderHistoryList CreateDataObject(string customerId)
        {
            var cohList = new CustomerOrderHistoryList
            {
                CustomerID = customerId
            };

            var rdr = _northwindSqlDatabase.CreateSqlDataReader("dbo.CustOrderHist",
                "@CustomerID", customerId);

            while (rdr.Read())
            {
                var coh = new CustomerOrderHistory
                {
                    ProductName = (string)rdr["ProductName"],
                    Total = (int)rdr["Total"]
                };
                cohList.customerOrderHistoriesList.Add(coh);
            }

            return cohList;
        }

    }
}
