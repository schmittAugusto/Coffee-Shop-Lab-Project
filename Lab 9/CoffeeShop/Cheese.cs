using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Cheese : MenuItemAddition
    {
        public Cheese(IMenuItem item) : base(item)
        {
            BaseCost = 0.40m;
            Description = "Cheese";
        }
    }
}
