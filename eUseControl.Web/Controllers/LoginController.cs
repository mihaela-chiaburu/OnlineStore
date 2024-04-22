using eUseControl.BuisnessLogic.Interfaces;
using eUseControl.Domain.Entities.Response;
using eUseControl.Domain.Entities.User;
using eUseControl.Web.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using eUseControl.Domain.Enums;

namespace eUseControl.Web.Controllers
{
    public class LoginController : Controller
    {

        private readonly ISession _session;
        public LoginController()
        {
            var bl = new BuisnessLogic.BuisnessLogic();
            _session = bl.GetSessionBL();
        }

        //GET: Login
        public ActionResult Index()
        {
            string userRole = "User";
            HttpContext.Session["UserRole"] = userRole;

            return RedirectToAction("Index", "Home");
        }
        //Post: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserLogin login)
        {

            if (ModelState.IsValid)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<UserLogin, ULoginData>());
                var data = Mapper.Map<ULoginData>(login);

                data.LoginIp = Request.UserHostAddress;
                data.LoginDateTime = DateTime.Now;

                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    HttpCookie cookie = _session.GenCookie(login.Credential);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View();
                }
            }

            return View();
        }

        public ActionResult Login(UserLogin data)
        {
            return View();
        }
    }
}