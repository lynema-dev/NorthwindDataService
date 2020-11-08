using System;
using System.Collections.Generic;
using System.Diagnostics;
using NorthwindDataService;
using NorthwindDataService.Factories;

namespace ConsoleApp
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Fetching Order Data ....");
            Console.WriteLine();

            string customerID = "OCEAN";
            
            var cof = new CustomerOrdersFactory(new NorthwindSqlDatabase());
            var co = cof.CreateDataObject(customerID);
            Console.WriteLine($"Customer Order Factory, @CustomerID: {customerID}");

            foreach (var i in co.customerOrderList)
            {
                string output = $"OrderID: {i.OrderID}, ShippedDate: {i.ShippedDate.ToShortDateString()}";
                Console.WriteLine(output);
            }

            Console.WriteLine();

            var cohf = new CustomerOrdersHistoryFactory(new NorthwindSqlDatabase());
            var coh = cohf.CreateDataObject(customerID);
            Console.WriteLine($"Customer Order History Factory, @CustomerID: {customerID}");

            foreach (var i in coh.customerOrderHistoriesList)
            {
                string output = $"Product Name: {i.ProductName}, Total: {i.Total}";
                Console.WriteLine(output);
            }

            Console.WriteLine();
            Console.WriteLine("....");
            Console.Read();
        }
    }
}
