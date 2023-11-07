using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Mayo : MenuItemAddition
    {
        public Mayo(IMenuItem item) : base(item)
        {
            BaseCost = 0.0m;
            Description = "Mayo";
        }
    }
}
