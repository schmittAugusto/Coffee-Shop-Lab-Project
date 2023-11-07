using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CoffeeShop
{
    public abstract class RepositoryBase
    {
        public abstract List<Customer> Customers { get; set; }
        public virtual void Save(string filename)
        {
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            });
            serializer.Serialize(writer, Customers);
            writer.Close();
            file.Close();   
        }
        public virtual void Load(string filename)
        {
            FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings{
                        Formatting = Formatting.Indented,
                        TypeNameHandling = TypeNameHandling.Auto});
            Customers = (List<Customer>)serializer.Deserialize(reader, typeof(List<Customer>));
            reader.Close();
            file.Close();       
            //resolving circular reference
            foreach (Customer customer in Customers)
            {
                if (customer != null)
                {
                    foreach (Order order in customer.Orders)
                    {
                        order.Customer = customer;
                    }
                }
            }
        }
    }
}