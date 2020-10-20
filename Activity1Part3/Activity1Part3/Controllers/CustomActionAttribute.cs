using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class CustomActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            MyLogger.GetInstance().Info("Using Controller: " + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + " and Method: " + filterContext.ActionDescriptor.ActionName);
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            MyLogger.GetInstance().Info("Executing Controller: " + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + " and Method: " + filterContext.ActionDescriptor.ActionName);
        }
    }
}