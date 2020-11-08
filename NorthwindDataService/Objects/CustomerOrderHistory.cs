using System;
using System.Collections.Generic;

namespace NorthwindDataService.Factories
{
    public class CustomerOrderHistory
    {
        public string ProductName { get; set; }
        public int Total { get; set; }
    }

    public class CustomerOrderHistoryList
    {
        private readonly List<CustomerOrderHistory> customerorderhistorylist = new List<CustomerOrderHistory>();

        public string CustomerID { get; set; }
        public IList<CustomerOrderHistory> customerOrderHistoriesList { get { return customerorderhistorylist; } }

    }
}
