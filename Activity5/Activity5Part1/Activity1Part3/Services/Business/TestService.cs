using Activity1Part3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace Activity1Part3.Services.Business
{
    public class TestService : ITestService
    {
        private ILogger Logger;

        [InjectionMethod]
        public void Initialize(ILogger logger)
        {           
            Logger = logger;
        }

        public void TestLogger()
        {
            Logger.Info("Test Logging in TestService.TestLogger() invoked.");
        }
    }
}