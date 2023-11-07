using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Lettuce : MenuItemAddition
    {
        public Lettuce(IMenuItem item) : base(item)
        {
            BaseCost = 0.30m;
            Description = "Lettuce";
        }
    }
}
