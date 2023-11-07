using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class OrderItem
    {
        private IMenuItem item;
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public IMenuItem Item
        {
            get { return item; }
            set { item = value; }
        }
        public OrderItem()
        {
            Cost = 0;
        }
        public OrderItem(IMenuItem menuItem)
        {
            Item = menuItem;
            Cost = menuItem.BaseCost;
            Description = menuItem.Description;
        }
        public override string ToString()
        {
            return $"{Description} {Cost:c}";
        }
    }
}
