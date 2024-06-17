using final_project.Database;
using final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final_project.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        FinalProjectEntities objModel = new FinalProjectEntities();
        public ActionResult Detail(int Id)
        {
            //code nay lay thong tin sp theo id truyen vao
            var objProduct = objModel.Products.Where(n => n.IDProduct == Id).FirstOrDefault();

            //code nay lay danh sach san pham 
            var lstProduct = objModel.Products.Where(n => n.IDProduct == objProduct.IDProduct).ToList();

            //
            ProductDetailModel objProductDetailModel = new ProductDetailModel();

            objProductDetailModel.objProduct = objProduct;
            objProductDetailModel.ListProduct = lstProduct;
            return View(objProductDetailModel);
        }
    }
}