using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Sweetener:MenuItemAddition
    {
        public Sweetener(IMenuItem item) : base(item)
        {
            BaseCost = 0.06m;
            Description = "Sweetener";
        }
    }
}
