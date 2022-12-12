using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AccessModifiers.Models
{
    public class Product
    {

        public Product(string name, decimal price, Category category) 
        {
            Name = name;
            Price = price;
            Category = category;


        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public string ReflectInfo()
        {
            return $"{Name} belongs to {Category.Name} and Price is{Price}";
            
        }
    }
}
