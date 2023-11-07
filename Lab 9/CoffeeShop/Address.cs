using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public struct Address
    {
        public string City;
        public string PostalCode;
        public string Province;
        public static Address SHOP_ADDRESS = new Address("2 King St.", "Toronto", "ON", "M1M 1M1");
        public string Street;
        public Address(string street, string city, string province, string postalCode)
        {
            Street = street;
            City = city;
            Province = province.ToUpper();
            PostalCode = postalCode.ToUpper();
        }
        public override string ToString()
        {
            return $"{Street}, {City}, {Province}, {PostalCode}";
        }
    }
}
