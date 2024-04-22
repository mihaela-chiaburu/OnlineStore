using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.BuisnessLogic.Interfaces;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Enums;
using eUseControl.Web.Models.User;


namespace eUseControl.Web.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            UserData u = new UserData();
            u.Name = "Customer";
            u.Products = new List<string> { "p1", "p2", "p3", "p4", "p5", "p6", "p7", "p8" };

            return View(u);
        }


        public ActionResult Product()
        {
            var product = Request.QueryString["p"];
            UserData u2 = TempData["UserData"] as UserData;
            if (u2 == null)
            {
                u2 = new UserData();
                u2.Name = "Customer";
                u2.Products = new List<string> { "p1", "p2", "p3", "p4", "p5", "p6", "p7", "p8" };
            }

            u2.SingleProduct = product;

            return View(u2);
        }


        [HttpPost]
        public ActionResult Product(string btn)
        {
            return RedirectToAction("Product", "Home", new { @btn = btn });
        }


        public ActionResult Shop()
        {
            UserData u3 = new UserData();
            u3.Name = "Customer";
            u3.Products = new List<string> { "p1", "p2", "p3", "p4", "p5", "p6", "p7", "p8" };

            return View(u3);
        }

        public ActionResult Contact()
        {
            ViewBag.AdminMessage = "Welcome Admin!";
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Testimonial()
        {
            return View();
        }
        public ActionResult Why()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}