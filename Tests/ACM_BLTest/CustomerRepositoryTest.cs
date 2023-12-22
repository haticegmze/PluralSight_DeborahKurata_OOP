using ACM_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM_BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //ARRANGE
            var customerRepository = new CustomerRepository();
            var excepted = new Customer(1)
            {

                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "frodo",
                LastName = "baggins"
            };
            //ACT
            var actual = customerRepository.Retrieve(1);


            //ASSERT

            //assert.arequel(actual,excepted) olmamasının sebebi aynı özellikleri taşısalarda farklı şekilde tanımlanan nesnleler( arrange'de yazdığımız ile act'de tanımladığımız "retrieve")
            //olmasından kaynaklıdır bunu çözebilmemizin tek yolu bütün property leri tek tek test etmemiz.
            Assert.AreEqual(excepted.CostumerID, actual.CostumerID);
            Assert.AreEqual(excepted.LastName, actual.LastName);
            Assert.AreEqual(excepted.FirstName, actual.FirstName);
            Assert.AreEqual(excepted.EmailAddress, actual.EmailAddress);


        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var excepted = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "frodo",
                LastName = "baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType=1,
                        StreetLine1="Bag End",
                        StreetLine2="bagshot row",
                        City="hobbiton",
                        State="shire",
                        Country="middle earth",
                        PostaCode="144"
                    },
                    new Address()
                    {
                        AddressType=2,
                        StreetLine1="green dragon",
                       City="bywater",
                       State="shire",
                       Country="middle earth",
                       PostaCode="146",

                    }
                }
            };

            var actual =customerRepository.Retrieve(1);
            Assert.AreEqual(excepted.CostumerID,actual.CostumerID);
            Assert.AreEqual (excepted.LastName, actual.LastName);   
            Assert.AreEqual(excepted.FirstName , actual.FirstName);
            Assert.AreEqual(excepted.EmailAddress, actual.EmailAddress);

            for(int i = 0;i<1;i++)
            {
                Assert.AreEqual(excepted.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(excepted.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(excepted.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(excepted.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(excepted.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(excepted.AddressList[i].PostaCode, actual.AddressList[i].PostaCode);
                              
            }












        }
        

    }
    
}
