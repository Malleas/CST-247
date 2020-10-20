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
using System.Runtime.Caching;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        [CustomAuthorization]
        public ActionResult onPrivateURL()
        {
            return Content("Private info, only logged in users can see this.");
        }

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        [CustomAction]
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
                    Session["user"] = user;
                    MyLogger.GetInstance().Info("Exit login controller.  Successful login");
                    return View("LoginPassed");
                }
                else
                {
                    Session.Clear();
                    MyLogger.GetInstance().Info("Exit login controller.  Login failed.");
                    return View("LoginFailed");
                }
            }
            catch (Exception e) {
                MyLogger.GetInstance().Error("Exception!" + e.Message);
                return Content("Exception in login" + e.Message);
            }
        }
       
        public ActionResult GetUsers()
        {
            var cache = MemoryCache.Default;

            List<UserModel> users = new List<UserModel>();

            users = (List<UserModel>) cache.Get("users");

            if(users == null)
            {
                users = new List<UserModel>();
                users.Add(new UserModel(1, "bob", "Password1"));
                users.Add(new UserModel(2, "Sue", "Password2"));
                users.Add(new UserModel(3, "Foo", "Bar"));
                MyLogger.GetInstance().Info("Users were not in the cache, i got them from the data source (slow) at " + DateTime.Now);

                var policy = new CacheItemPolicy().AbsoluteExpiration = DateTime.Now.AddMinutes(1);
                cache.Set("users", users, policy);
            }
            else
            {
                MyLogger.GetInstance().Info("Users were in the cache, (fast) at " + DateTime.Now);
            }

            

            return Content(new JavaScriptSerializer().Serialize(users));
        }

       
    }
}