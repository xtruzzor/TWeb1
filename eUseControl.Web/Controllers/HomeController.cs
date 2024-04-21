using eUseControl.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Web.Controllers
{
    public class HomeController : Controller 
    {
        // GET: Home
        public ActionResult Index()
        {

            UserData u = new UserData();
            u.Username = "Liviu";
            u.Products = new List<Product>
            {
                new Product { Name = "Product #1", ImageUrl = "/img/game1.png" },
                new Product { Name = "Product #2", ImageUrl = "/img/game2.png" },
                new Product { Name = "Product #3", ImageUrl = "/img/game3.png" },
                new Product { Name = "Product #4", ImageUrl = "/img/game4.png" }
            };

            return View(u);
        }

        public ActionResult Product()
        {

            var product = Request.QueryString["p"];

            UserData u = new UserData();
            u.Username = "UserName";
            u.SingleProduct = product; 


            return View(u);
        }

        [HttpPost]
        public ActionResult Product(string btn)
        {
            return RedirectToAction("Product", "Home", new {@p = btn});
        }
         

    }

}
