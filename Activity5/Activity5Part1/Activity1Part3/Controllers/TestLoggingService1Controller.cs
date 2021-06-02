using Activity1Part3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService1Controller : Controller
    {
        private readonly ILogger Logger;

        public TestLoggingService1Controller(ILogger logger)
        {
            this.Logger = logger;
        }

        // GET: TestLoggingService1
        public ActionResult Index()
        {
            Logger.Info("Logger Event Successful!");
            return Content("Logger event Successful!");
        }
    }
}