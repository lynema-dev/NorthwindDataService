using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthwindDataService.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using System.Diagnostics;

namespace NorthwindDataService.Tests
{
    [TestClass()]
    public class UnitTestsTests
    {
        [TestMethod()]
        public void CustomerOrderHistory()
        {
            var coh = new CustomerOrdersHistoryFactory(new NorthwindSqlDatabase());
            var obj = coh.CreateDataObject("CONSH");

            Assert.AreEqual(obj.CustomerID, "CONSH");
            Assert.AreEqual(obj.customerOrderHistoriesList.Count, 7);
        }

        [TestMethod()]
        public void NorthwindSqlDatabaseConnectionTest()
        {
            var northwindSqlDatabase = new NorthwindSqlDatabase();
            Assert.IsNotNull(northwindSqlDatabase);
        }

    }
}