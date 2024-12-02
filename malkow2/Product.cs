using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace malkow2
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        // конструктор
        public Product(string name, decimal price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        // деконструктор
        public void Deconstruct(out string name, out decimal price, out string description)
        {
            name = Name;
            price = Price;
            description = Description;
        }

    }
}
