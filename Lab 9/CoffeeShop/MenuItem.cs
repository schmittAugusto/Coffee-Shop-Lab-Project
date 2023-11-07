using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShop
{
    public abstract class MenuItem : IMenuItem
    {
        [JsonProperty]protected decimal baseCost;
        [JsonProperty]protected string description;
        public virtual decimal BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }
        public virtual string Description
        {
            get { return description; }
            set { description = value; }
        }
        public MenuItem()
        {
        }
        public MenuItem(string description, decimal baseCost)
        {
            BaseCost = baseCost;
            Description = description;
        }
        public override string ToString()
        {
            return $"Description: {Description} \n\t Bast cost: {BaseCost:c}";
        }
    }
}
