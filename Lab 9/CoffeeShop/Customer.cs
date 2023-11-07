using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShop
{
    public class Customer
    {
        private static ulong _ID = 1;
        private Address address;
        private ulong idNumber;
        private string name;
        private List<Order> orders;
        private ulong phone;
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        public ulong IdNumber
        {
            get { return idNumber; }
            private set { idNumber = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        public ulong Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public Customer()
        {
            IdNumber = _ID++;
            Orders = new List<Order>();
        }
        public Customer(string name, uint phoneNumber, Address address):this()
        {
            Name = name;
            Phone = phoneNumber;
            Address = address;
        }
        public Order AddOrder(Order order)
        {
            Orders.Add(order);
            order.Customer = this;
            return order;
        }
        public Order CreatePhoneOrder(Address deliveryAddress)
        {
            Order order = new Order();
            order.Customer = this;
            order.OrderType = OrderType.PhoneOrder;
            order.DeliveryAddress = deliveryAddress;
            Orders.Add(order);
            return order;
        }
        public override string ToString()
        {
            return $"Customer: ID:{IdNumber}, Name:{Name},\n\tAddress: {Address}, Phone: {Phone}\n" +
                $"{"",6}Order detail:{string.Join(" \n", Orders)} \n";
        }

    }
}
