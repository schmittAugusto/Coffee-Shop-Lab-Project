using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public interface IMenuItem
    {
        decimal BaseCost { get; set; }
        string Description { get; set; }
    }
}
