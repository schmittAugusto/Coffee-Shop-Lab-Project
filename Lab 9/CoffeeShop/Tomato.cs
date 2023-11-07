using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Tomato : MenuItemAddition
    {
        public Tomato(IMenuItem item) : base(item)
        {
            BaseCost = 0.35m;
            Description = "Tomato";
        }
    }
}
