using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass()]
    class CustomerRepositoryTest
    {
        [TestMethod()]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected, actual);
        }

    }
}
