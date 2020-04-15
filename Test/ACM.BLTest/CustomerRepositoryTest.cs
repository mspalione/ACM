using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using ACM.BL;
using System.Collections.Generic;
//not being read by testing
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

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "",
                FirstName = "",
                LastName = "",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                    StreetLineOne = "Bag End",
                    StreetLineTwo = "Bagshot row",
                    City = "Hobbiton",
                    StateProvince = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                    StreetLineOne = "Green Dragon",
                    City = "Bywater",
                    StateProvince = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "146"
                    }
                }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLineOne, actual.AddressList[i].StreetLineOne);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].StateProvince, actual.AddressList[i].StateProvince);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
