using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesValid()
        {
            var source = "sonic screwdriver";
            var excepted = "sonic screwdriver";


            var actual = source.InsertSpaces();
            Assert.AreEqual(excepted, actual);

        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            var source = "sonic screwdriver";
            var excepted = "sonic screwdriver";

            var actual = source.InsertSpaces();
            Assert.AreEqual(excepted, actual);
        }

    }
}
