using ACM_BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Remoting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "frodo",
                LastName = "baggins",
                AddressList = null

            };
            changedItems.Add(customer);
            var product = new Product(2)
            {
                ProductName = "rake",
                ProductDescription = "garden rake with steel head",
                currentPrice = 6M
            };
            changedItems.Add(product);
            LoggingService.WriteToFlile(changedItems);
        }
    }
}
