using final_project.Database;
using final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final_project.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        FinalProjectEntities objModel = new FinalProjectEntities();
        public ActionResult Shop()
        {
            var lstProduct = objModel.Products.ToList();
            var lstCatagories = objModel.Categogies.ToList();
            var lstBrand = objModel.Brands.Where(s => s.Title == true).ToList();
 
            Shop_Product objShop_Product = new Shop_Product();

            objShop_Product.ListProducts = lstProduct;
            objShop_Product.ListCatagories = lstCatagories;
            objShop_Product.ListBrand = lstBrand;

            return View(objShop_Product);
        }
    }
}