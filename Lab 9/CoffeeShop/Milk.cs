using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Milk : MenuItemAddition
    {
        public Milk(IMenuItem item): base(item)
        {
            BaseCost = 0.1m;
            Description = "Milk";
        }
    }
}
