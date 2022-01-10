using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Controller
{
    class ProductController
    {
        private List<Products> _products = new List<Products>();

        public void create(string name, Brand brand, Category category, decimal weight, decimal price)
        {

        }

        public List<Products> GetAll()
        {
            return _products;
        }

        public void Update(int Id, string name, Brand brand, Category category, decimal weight, decimal price)
        {

        }

        public void Delete(int Id)
        {

        }
    }
}
