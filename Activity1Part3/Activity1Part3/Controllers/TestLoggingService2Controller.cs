using Activity1Part3.Services.Utility;
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
        public string Index()
        {
            logger.Info("Hello fromt he Test Logger Service 2 Index()");
            return "Hello from the Test Logging Service 2 Index()";
        }
    }
}