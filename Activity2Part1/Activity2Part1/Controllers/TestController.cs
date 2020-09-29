using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> userList = new List<UserModel>();
            UserModel user = new UserModel();

            user.Name = "Bob";
            user.EmailAddress = "me@home.com";
            user.PhoneNumber = "1234567890";
            userList.Add(user);

           
            
            return View("Test", userList);
        }
    }
}