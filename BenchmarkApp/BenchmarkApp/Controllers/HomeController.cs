using Benchmark.Models;
using Benchmark.Services.Business;
using Benchmark.Services.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace Benchmark.Controllers
{
    public class HomeController : Controller
    {
        [Dependency]
        public SecurityService securityService { get; set; }
       


        public ActionResult Index()
        {
            return View("Home");
        }

      public ActionResult OnClick(string navBtn)
        {
            if (navBtn.Equals("0"))
            {
                return View("Input");
            }else 
            {
                return View("Search");
            }
        }

        [HttpPost]
        public ActionResult onSubmit(Verse verse)
        {
            bool results = securityService.createVerse(verse);
            if (results)
            {
                return View("Success");
            }
            else
            {
                return View("Fail");
            }
            
        }

        [HttpPost]
        public ActionResult onSearch(Verse verse)
        {

            List<Verse> results = securityService.getVerse(verse);

            return View("SearchResults", results);

        }

        [HttpPost]
        public ActionResult onNavigation(string navBtn)
        {
            if (navBtn.Equals("0"))
            {
                return View("Home");
            }else if (navBtn.Equals("1"))
            {
                return View("Input");
            }
            else
            {
                return View("Search");
            }
        }
    }
}