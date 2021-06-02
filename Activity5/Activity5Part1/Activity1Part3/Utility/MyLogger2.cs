using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity1Part3.Utility
{
    public class MyLogger2 : ILogger
    {
        //private MyLogger2 instance;
        private Logger logger;        

        public Logger GetLogger()
        {
            if (logger == null)
            {
                logger = LogManager.GetLogger("myAppLoggerRules");
            }
            return logger;
        }
        public void Debug(string message)
        {
            GetLogger().Debug(message);
        }

        public void Error(string message)
        {
            GetLogger().Error(message);
        }

        public void Info(string message)
        {
            GetLogger().Info(message);
        }

        public void Warning(string message)
        {
            GetLogger().Warn(message);
        }
    }
}