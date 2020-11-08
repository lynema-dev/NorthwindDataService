using System;
using System.Collections.Generic;

namespace NorthwindDataService.Factories
{
    public class CustomerOrder 
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
    }

    public class CustomerOrderList 
    {
        private readonly List<CustomerOrder> customerorderlist = new List<CustomerOrder>();

        public IList<CustomerOrder> customerOrderList { get { return customerorderlist; } }
        public string CustomerID { get; set; }

    }
}
