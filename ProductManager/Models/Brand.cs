using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductManager.Models
{
    class Brand : Imodel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Street { get; set; }
        public string  Zip { get; set; }
        public string Locality { get; set; }
        public string  Country { get; set; }

        public Brand(int id, string name, string street, string zip, string locality, string country)
        {
            Id = id;
            Name = name;
            Street = street;
            Zip = zip;
            Locality = locality;
            Country = country;
        }
    }
}
