using final_project.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_project.Models
{
    public class Home_Product
    {
        public List<Slider> ListSlider { get; set; }
        public List<Home> Banner1 { get; set; }
        public List<Home> Banner2 { get; set; }
        public List<Home> Banner3 { get; set; }
        public List<Product> ListProductsNew { get; set; }
        public List<Product> ListProductsBestseller { get; set; }
    }
}