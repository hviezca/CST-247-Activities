using System;
using System.Web.Mvc;
using Activity1Part3.Services.Business;
using Activity1Part3.Models;

namespace Activity1Part3.Controllers
{
    internal class CustomAuthorizationAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            SecurityService securityService = new SecurityService();

            // get the user from a session variable
            UserModel user = (UserModel)filterContext.HttpContext.Session["user"];

            bool success = false;

            if (user != null)
            {
                success = securityService.Authenticate(user);
            }                                

            if (success)
            {
                // do nothing. login was successful.
            }
            else
            {
                filterContext.Result = new RedirectResult("/Login");
            }
        }       
    }
}