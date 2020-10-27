using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;

namespace Activity1Part3.Services.Utility
{
    public class MyLogger2 : ILogger
    {

        
        private  Logger logger;

       

        

        private Logger GetLogger(string theLogger)
        {
            if (logger == null)
            {
                logger = LogManager.GetLogger(theLogger);
            }
            return logger;
        }

        public void Debug(string message, string arg = null)
        {
            if (arg == null)
            {
                GetLogger("myAppLoggerRules").Debug(message);
            }
            else
            {
                GetLogger("myAppLoggerRules").Debug(message);
            }
        }

        public void Error(string message, string arg = null)
        {
            if (arg == null)
            {
                GetLogger("myAppLoggerRules").Error(message);
            }
            else
            {
                GetLogger("myAppLoggerRules").Error(message);
            }
        }

        public void Info(string message, string arg = null)
        {
            if (arg == null)
            {
                GetLogger("myAppLoggerRules").Info(message);
            }
            else
            {
                GetLogger("myAppLoggerRules").Info(message);
            }
        }

        public void Warning(string message, string arg = null)
        {
            if (arg == null)
            {
                GetLogger("myAppLoggerRules").Warn(message);
            }
            else
            {
                GetLogger("myAppLoggerRules").Warn(message);
            }
        }
    }
}