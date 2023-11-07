using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Sugar : MenuItemAddition
    {
        public Sugar(IMenuItem item) : base(item)
        {
            BaseCost = 0.05m;
            Description = "Sugar";
        }
    }
}
