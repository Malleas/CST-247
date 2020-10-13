using Activity3Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity3Part1.Controllers
{
    public class CustomerController : Controller
    {
        Customer customer;
        List<Customer> customerList;
       
        public CustomerController()
        {
            customerList = new List<Customer>();
            customerList.Add(new Customer(0, "Bob", 27));
            customerList.Add(new Customer(1, "Matt", 38));
            customerList.Add(new Customer(2, "Sue", 62));
        }
       
        
        // GET: Customer
        public ActionResult Index()
        {

            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customerList, customerList[0]);
            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
           

            return PartialView("_CustomerDetails", customerList[Int32.Parse(CustomerNumber)]);
        }

        [HttpPost]

        public ActionResult GetMoreInfo(string CustomerNumber)
        {
            return PartialView("_CustomerDetails", "Hello World");
           
        }
    }
}