using BibleVerseApp.Models;
using BibleVerseApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseApp.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View("Register");
        }

        public ActionResult Register(User user)
        {
            UserSecurityService service = new UserSecurityService();
            var result = service.Register(user);

            if (result)
            {
                //ViewBag.Message = "User Registered!"; ->  For debugging only
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.Message = "Registration failed...";
                return View();
            }
        }
    }
}