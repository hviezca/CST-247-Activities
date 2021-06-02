using Activity1Part3.Services.Business;
using Activity1Part3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService3Controller : Controller
    {
        private readonly ILogger Logger;
        private readonly ITestService Service;

        public TestLoggingService3Controller(ILogger logger, ITestService service)
        {
            Logger = logger;
            Service = service;
        }



        // GET: TestLoggingService3
        public ActionResult Index()
        {
            Logger.Info("Test Logging in TestLoggingSerice3.Logger.Info() Successful!");
            Service.Initialize(Logger);
            Service.TestLogger();
            return Content("Test Logging in TestLoggingSerice3.Logger.Info() and Service.TestLogger() Successful!");
        }
    }
}