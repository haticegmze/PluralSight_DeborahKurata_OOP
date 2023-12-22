using ACM_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM_BLTest
{
    [TestClass()]
    public class OrderRepositoryTests
    {
        [TestMethod()]
        public void RetrieveOrderDisplayTest()
        {
            var orderRepository = new OrderRepository();
            var excepted = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                                    new TimeSpan(7, 0, 0)),
            };
            var actual = orderRepository.Retrieve(10);

            Assert.AreEqual(excepted.OrderDate,actual.OrderDate);
        }
    }
}
