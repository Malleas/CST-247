using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;
using System.Web.Script.Serialization;
using Activity1Part3.Services.Utility;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(UserModel user)
        {
            MyLogger.GetInstance().Info("Entering LoginController.Login Using the new Singleton MyLogger Class");

            try {

                if (!ModelState.IsValid)
                {
                    return View("Login");
                }
                SecurityService service = new SecurityService();
                MyLogger.GetInstance().Info("Parameters are: " + new JavaScriptSerializer().Serialize(user));
                bool result = service.Authenticate(user);


                if (result)
                {
                    MyLogger.GetInstance().Info("Exit login controller.  Successful login");
                    return View("LoginPassed");
                }
                else
                {
                    MyLogger.GetInstance().Info("Exit login controller.  Login failed.");
                    return View("LoginFailed");
                }
            }
            catch (Exception e) {
                MyLogger.GetInstance().Error("Exception!" + e.Message);
                return Content("Exception in login" + e.Message);
            }
        }
    }
}