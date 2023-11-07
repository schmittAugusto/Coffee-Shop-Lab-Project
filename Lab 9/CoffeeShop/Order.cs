using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShop
{
    public enum OrderType { PhoneOrder, RestaurantOrder }

    public class Order
    {
        private decimal cost;
        [JsonIgnore] private Customer customer;
        private bool isDelivered;
        private Address deliveryAddress;
        private DateTime deliveryTime;
        private List<OrderItem> items;
        private static uint _ID = 1;
        private uint orderId;
        private DateTime orderTime;
        private OrderType orderType;

        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        [JsonIgnore]
        public Customer Customer
        {
            get { return customer; }
            set 
            {
                if (customer == null || customer != value)
                {
                    customer = value;
                }
                else
                {
                    Console.WriteLine("Something went wrong! Customer cannot ba changed once assigned");
                }
            }
        }
        public bool IsDelivered
        {
            get { return isDelivered; }
            set { isDelivered = value; }
        }
        public Address DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }
        public DateTime DeliveryTime
        {
            get { return deliveryTime; }
            set 
            {
                if (deliveryTime == null && IsDelivered)
                {
                    deliveryTime = DateTime.Now;
                }
                else if (deliveryTime != null)
                {
                    deliveryTime = value;
                }
                else
                {
                    deliveryTime = DateTime.MinValue;
                }
            }
        }
        public List<OrderItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        public uint OrderId
        {
            get { return orderId; }
            private set { orderId = value; }
        }
        public DateTime OrderTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }
        public OrderType OrderType
        {
            get { return orderType; }
            set { orderType = value; }
        }
        public Order()
        {
            OrderType = OrderType.RestaurantOrder;
            DeliveryAddress = new Address("1 King St.", "Toronto", "ON", "M1M 1M1");
            Items = new List<OrderItem>();
            OrderTime = DateTime.Now;
            DeliveryTime = OrderTime;
            IsDelivered = false;
            OrderId = _ID++;
        }
        public Order(Customer customer, OrderType orderType, Address deliveryAddress)
        {
            Customer = customer;
            DeliveryAddress = deliveryAddress;
            OrderType = orderType;
            Items = new List<OrderItem>();
            OrderTime = DateTime.Now;
            OrderId = _ID++;
            IsDelivered = false;
            if (OrderType == OrderType.PhoneOrder)
            {
                IsDelivered = false;
            }
        }
        public void AddOrderItem(IMenuItem menuItem)
        {
            OrderItem item = new OrderItem(menuItem);
            Items.Add(item);
            Cost += item.Cost;
        }
        public void Deliver()
        {
            DeliveryTime = DateTime.Now;
            IsDelivered = true;
        }
        public override string ToString()
        {
            return $"\n\tOrder number:{OrderId}\n\tCustomer name:{Customer.Name}\n\tOrder time:{OrderTime.ToString("hh:mm tt")}\n\tCost:{Cost:c}" +
                $"\n\tDelivery address:{DeliveryAddress} \n\t{string.Join("\n\t",Items)}";
        }
    }
}
