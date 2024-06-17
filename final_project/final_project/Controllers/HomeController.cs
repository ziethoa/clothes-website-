

using final_project.Database;
using final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final_project.Controllers
{
    public class HomeController : Controller
    {
        FinalProjectEntities objModel = new FinalProjectEntities();
        public ActionResult Index()
        {
            var lstSlider = objModel.Sliders.ToList();
            var lstBanner1 = objModel.Homes.Where(s => s.IDHome == 1).ToList();
            var lstBanner2 = objModel.Homes.Where(s => s.IDHome == 2).ToList();
            var lstBanner3 = objModel.Homes.Where(s => s.IDHome == 3).ToList();

            var lstProductNew = objModel.Products.Where(s=>s.IsNew==true).ToList();
            var lstProductBestseller = objModel.Products.Where(s => s.IsBestSaller == true).ToList();
            

            Home_Product objHome_Product = new Home_Product();

            objHome_Product.ListSlider = lstSlider;
            objHome_Product.Banner1 = lstBanner1;
            objHome_Product.Banner2 = lstBanner2;
            objHome_Product.Banner3 = lstBanner3;

            objHome_Product.ListProductsNew = lstProductNew;
            objHome_Product.ListProductsBestseller = lstProductBestseller;
            

            return View(objHome_Product);
        }

       
    }
}