using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Activity1Part3.Services.Utility;

namespace Activity1Part3.Services.Business
{
    public class TestService : ITestService
    {
        private ILogger logger;

        public TestService(ILogger logger)
        {
            this.logger = logger;
        }

        public void Initialize(ILogger logger)
        {
            this.logger = logger;
        }

        public void TestLogger()
        {
            logger.Info("Hello from the Test Servce TestLogger()");
        }
    }
}