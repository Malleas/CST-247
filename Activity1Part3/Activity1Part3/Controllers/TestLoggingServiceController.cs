using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingServiceController : Controller
    {
        private ILogger myLogger;

        public TestLoggingServiceController(ILogger logger)
        {
            myLogger = logger;
        }

        // GET: TestLoggingService
        public string Index()
        {
            myLogger.Info("Hello from Test Logging Service Index()");
            return "Test Logging Service Index()";
        }
    }
}