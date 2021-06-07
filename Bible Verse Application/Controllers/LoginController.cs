using BibleVerseApp.Models;
using BibleVerseApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {            
            return View("Login");
        }

        public ActionResult Login(User user)
        {
            UserSecurityService service = new UserSecurityService();
            var result = service.Login(user);

            if (result)
            {
                ViewBag.Message = "Login Success!!";
                return View("LoginSuccess");
            }
            else
            {
                ViewBag.Message = "Login Failed....";
                return View("LoginFailure");
            }
            
        }
    }
}