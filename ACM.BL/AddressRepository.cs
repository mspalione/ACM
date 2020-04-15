using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class AddressRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            //Create the instance of the Address class
            //Pass in the requested Id
            Address address = new Address(addressId);

            //code that retrieves the defined address

            //Temporary hard coded values to return a populated address
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLineOne = "Bag End";
                address.StreetLineTwo = "Bagshot row";
                address.City = "Hobbiton";
                address.StateProvince = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }


        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //code that retrieves the defined addresses for the customer

            //temp hard-coded values to return a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLineOne = "Bag End",
                StreetLineTwo = "Bagshot row",
                City = "Hobbiton",
                StateProvince = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLineOne = "Green Dragon",
                City = "Bywater",
                StateProvince = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }
        public bool Save(Address address)
        {
            //code that saves the passed in address

            return true;
        }
    }
}
