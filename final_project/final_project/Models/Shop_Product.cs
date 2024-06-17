using final_project.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_project.Models
{
    public class Shop_Product
    {
        public List<Product> ListProducts { get; set; }
        public List<Categogy> ListCatagories { get; set; }
        public List<Brand> ListBrand { get; set; } 
    }
}