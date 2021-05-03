using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> model = new List<UserModel>();

            model.Add(new UserModel()
            {
                Name = "Hiram",
                EmailAddress = "Hiram.test@test.com",
                PhoneNumber = "555-555-5555"
            });
            model.Add(new UserModel()
            {
                Name = "Sherlock",
                EmailAddress = "Sherlock.test@test.com",
                PhoneNumber = "555-541-5555"
            });
            model.Add(new UserModel()
            {
                Name = "Watson",
                EmailAddress = "Watson.test@test.com",
                PhoneNumber = "555-541-5574"
            });
            return View("Test", model);
        }
    }
}