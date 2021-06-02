using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using Activity1Part3.Utility;
using NLog;
using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Activity1Part3.Controllers
{
    [CustomAction]
    public class LoginController : Controller
    {       
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpGet]
        [CustomAuthorization]
        public ActionResult Protected()
        {
            return Content("I am a protected method if the proper attibute is applied to me.");
        }
        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            //MyLogger1.GetInstance().Info(" Entering LoginController.Login()");
            //MyLogger1.GetInstance().Info(" Parameters are " + new JavaScriptSerializer().Serialize(model));

            // Validate the Form POST
            if (!ModelState.IsValid)
                return View(" LoginFailed");

            SecurityService securityService = new SecurityService();
            var result = securityService.Authenticate(model);

            try
            {
                if (result)
                {
                    Session["user"] = model;
                    //MyLogger1.GetInstance().Info(" Exit LoginController.Login() with login passing");
                    return View("LoginPassed", model);
                }
                else
                {
                    Session.Clear();
                    //MyLogger1.GetInstance().Warning(" Exit LoginController.Login() with login failing");
                    return View("LoginFailed");
                }
            }
            catch (System.Exception e)
            {
                MyLogger1.GetInstance().Error(" Exception LoginController.Login()" + e.Message);
                throw;
            }
        }

        public ActionResult GetUsers()
        {
            // demo of a cached version of the app

            var cache = MemoryCache.Default;

            List<UserModel> users = new List<UserModel>();

            users = (List<UserModel>)cache.Get("users");

            if (users == null)
            {
                MyLogger1.GetInstance().Info(" Cache is empty. Creating new user list and adding to cache.");
                users = new List<UserModel>();
                users.Add(new UserModel(0, "Hiram", "asdf"));
                users.Add(new UserModel(1, "Sherlock", "qwer"));
                users.Add(new UserModel(2, "Watson", "fdsa"));
                users.Add(new UserModel(3, "Meep", "rewq"));
                users.Add(new UserModel(4, "Jack", "zxcv"));
                users.Add(new UserModel(5, "Lucy", "vcxz"));

                var policy = new CacheItemPolicy().AbsoluteExpiration = DateTime.Now.AddMinutes(1);
                // Add the list to the cache
                cache.Set("users", users, policy);
            }
            else
            {
                MyLogger1.GetInstance().Info(" Users found in cache.");
            }

            

            return Content(new JavaScriptSerializer().Serialize(users));
        }
    } 
}