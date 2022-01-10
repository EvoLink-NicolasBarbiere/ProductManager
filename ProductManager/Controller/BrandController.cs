using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProductManager.Controller
{
    class BrandController
    {
        private List<Brand> _brands = new List<Brand>();

        public void Create(string name, string street, string zip, string locality, string country)
        {

        }
        public List<Brand> Getall()
        {
            return _brands;
        }
        public void Update(int id, string name, string street, string zip, string locality, string country) 
        { 
            
        }
        public void Delete(int one)
        {

        }
    }
}
