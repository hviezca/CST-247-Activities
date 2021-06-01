using Activity1Part3.Models;
using Activity1Part3.Utility;
using System;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    internal class CustomActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            UserModel model = (UserModel)filterContext.HttpContext.Session["user"];

            if (model != null)
            {
                MyLogger1.GetInstance().Info(" User that logged in: " + model.toString());
                MyLogger1.GetInstance().Info(" Entering " + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "." + filterContext.ActionDescriptor.ActionName);
            }
            else
            {
                MyLogger1.GetInstance().Info(" Leaving " + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "." + filterContext.ActionDescriptor.ActionName);
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            MyLogger1.GetInstance().Info(" Entering " + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "." + filterContext.ActionDescriptor.ActionName);
        }
    }
}