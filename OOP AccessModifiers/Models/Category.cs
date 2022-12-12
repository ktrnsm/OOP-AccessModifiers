using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AccessModifiers.Models
{
    public class Category
    {


        public Category(string name, string inform)
        {
            Name = name;
            Inform = inform;
            CreatedDate = DateTime.Now;
            Products = new List<Product>();

        }

        public string Name { get; set; }
        public string Inform { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Product> Products { get; set; }
    }
}
