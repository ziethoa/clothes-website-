﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final_project.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}