using Activity1Part3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService2Controller : Controller
    {
        [Dependency]
        public ILogger logger { get; set; }


        // GET: TestLoggingService2
        public ActionResult Index()
        {
            logger.Info("TestLoggerService2 Test Successful!");
            return Content("TestLoggerService2 Test Successful!");
        }
    }
}