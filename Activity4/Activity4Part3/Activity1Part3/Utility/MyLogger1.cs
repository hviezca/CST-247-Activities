using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity1Part3.Utility
{
    public class MyLogger1 : ILogger
    {
        // Singleton design patter used here

        private static MyLogger1 instance;
        private static Logger logger;

        public static MyLogger1 GetInstance()
        {
            if (instance == null)
            {
                instance = new MyLogger1();
            }
            return instance;
        }

        public Logger GetLogger()
        {
            if(MyLogger1.logger == null)
            {
                MyLogger1.logger = LogManager.GetLogger("myAppLoggerRules");
            }
            return MyLogger1.logger;
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