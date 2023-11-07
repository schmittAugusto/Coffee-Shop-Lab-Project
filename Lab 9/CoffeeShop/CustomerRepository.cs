using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class CustomerRepository : RepositoryBase
    {
        public override List<Customer> Customers { get; set; }
        public CustomerRepository()
        {
            Customers = new List<Customer>();
        }
        public void Add(Customer customer)
        {
            Customers.Add(customer);
        }
        
    }
}
