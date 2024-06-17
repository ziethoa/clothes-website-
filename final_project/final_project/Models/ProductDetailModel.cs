using final_project.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_project.Models
{
    public class ProductDetailModel
    {
        public Product objProduct { get; set; } 
        public List<Product> ListProduct { get; set; }
    }
}