using System;
using System.Data.SqlClient;


namespace NorthwindDataService.Factories
{
    public class CustomerOrdersFactory : CustomerOrder
    {
        private readonly INorthwindSqlDatabase _northwindSqlDatabase;

        public CustomerOrdersFactory(INorthwindSqlDatabase northwindSqlDatabase)
        {
            _northwindSqlDatabase = northwindSqlDatabase;
        }

        public CustomerOrderList CreateDataObject(string customerId)
        {
            var coList = new CustomerOrderList
            {
                CustomerID = customerId
            };

            var rdr = _northwindSqlDatabase.CreateSqlDataReader("dbo.CustOrdersOrders",
                "@CustomerID", customerId);

            while (rdr.Read())
            {
                var co = new CustomerOrder
                {
                    OrderID = (int)rdr["OrderID"],
                    OrderDate = (DateTime)rdr["OrderDate"],
                    RequiredDate = (DateTime)rdr["RequiredDate"],
                    ShippedDate = (DateTime)rdr["ShippedDate"]

                };
                coList.customerOrderList.Add(co);
            }

            return coList;
        }
    }


}
