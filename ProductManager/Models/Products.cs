using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Models
{
    class Products : Imodel
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }

        public Products(int id, string name, Brand brand, Category category, decimal weight, decimal price)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Category = category;
            Weight = weight;
            Price = price;
        }
    }
}
