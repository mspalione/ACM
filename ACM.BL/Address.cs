using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address
    {
        public Address() { }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; set; }
        public string StreetLineOne { get; set; }
        public string StreetLineTwo { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(StreetLineOne)) isValid = false;
            if (PostalCode == null) isValid = false;


            return isValid;
        }
    }
}
