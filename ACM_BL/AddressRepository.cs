using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class AddressRepository // adres deposu
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "hobbiton";
                address.State = "shire";
                address.Country = "middle earth";
                address.PostaCode = "144";
            }
            return address;



        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1);
            {

                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "hobbiton";
                address.State = "shire";
                address.Country = "middle earth";
                address.PostaCode = "144";
            };
            addressList.Add(address);
            address = new Address(2);
            {
                address.AddressType = 2;
                address.StreetLine1 = "green dragon";
                address.City = "bywater";
                address.State = "shire";
                address.Country = "middle earth";
                address.PostaCode = "146";

            };
            addressList.Add(address);
            return addressList;
        }

        public bool save(Address address)
        {
            return true;
        }

    }
}
