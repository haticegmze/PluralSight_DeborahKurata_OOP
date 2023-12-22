using ACM_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace ACM_BLTest
{
    [TestClass]
    public class CustomerTest
    {
       /* [TestMethod]
        public void FullNameValid()
        {
            //--ARRANGE
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string excepted = "Baggins,Bilbo";
            //--ACT
            string actual = customer.FullName;
            //--ASSERT
            //(BU KISIMDA BEKLENEN DEĞERİN GERÇEK DEĞERE EŞİT OLUP OLMADIĞINI DOĞRULARIZ)
            Assert.AreEqual(actual, excepted);


        }*/
       [TestMethod]
            public void FullNameLastNameEmty()
         {
             Customer customer = new Customer
             {
                 FirstName = "bilbo"

             };
             string excepted = "bilbo";
             string actual = customer.FullName;
             Assert.AreEqual(actual, excepted);
         } 

        [TestMethod]

        // bu testte , new keyword'ünü kullanarak üç yeni müşteri oluşturuyoruz.
        public void StaticTest()
        {
            //--ARRANGE

            //bildirimlerinizi kısatmak için "var" keyword'ünü kullanabiliriz.
            var c1 = new Customer();
            c1.FirstName = "bilbo";
            //bu testte örnekleri saymak için her nesne oluşturduktan sonra bu özelliği arttırıyoruz.( Customer.InstanceCount += 1;)
            Customer.InstanceCount += 1;
            
            
            var c2 = new Customer();
            c2.FirstName = "frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "roise";
            Customer.InstanceCount += 1;


            //--ACT
             


            //--ASSERT
            Assert.AreEqual(3, Customer.InstanceCount);

        }
        [TestMethod]
        public void ValidateValid()
        {
            //ARRANGE
            var customer = new Customer
            {
                LastName="baggins",
                EmailAddress="fbaggins@hobbiton.me"
            };
            var excepted = false;

            //ACT 
            //validate yöndetmini çağırarak harekete geçiriyoruz
            var actual = customer.Validate();

            //ASSERT
            //girdiğimiz değerlerin gerçek değerlerine eşit olup olmadığıı kontrol ediyoruz.
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        //BU TEST BİR E POSTA ADRESİ VERİLMESİNİ SAĞLAR ANCAK BİR AD VERİLMEZ ÇÜNKÜ SOYADI SAĞLANMADIĞI İÇİN YÖNTEM YANLIŞ DÖNER.
        public void ValidateMissingLastName()
        {
            //ARRANGE
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbit.me"
            };
            var excepted = false;

            //ACT
            var actual = customer.Validate();


            //ASSERT
            Assert.AreEqual(excepted, actual);









        }







    }
}
