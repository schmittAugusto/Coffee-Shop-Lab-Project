using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShop
{
    public abstract class MenuItemAddition : MenuItem
    {
        [JsonProperty]private IMenuItem menuItem;
        public override decimal BaseCost
        {
            get { return menuItem.BaseCost + base.baseCost; }
            set { baseCost = value; }
        }
        public override string Description
        {
            get { return menuItem.Description + ", " + base.description; }
            set { description = value; }
        }
        public MenuItemAddition(IMenuItem item)
        {
            menuItem = item;
        }
    }
}