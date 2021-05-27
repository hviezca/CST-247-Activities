using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using Activity1Part3.Utility;
using NLog;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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
        public ActionResult Login(UserModel model)
        {
            MyLogger1.GetInstance().Info(" Entering LoginController.Login()");
            MyLogger1.GetInstance().Info(" Parameters are " + new JavaScriptSerializer().Serialize(model));

            // Validate the Form POST
            if (!ModelState.IsValid)
                return View(" LoginFailed");

            SecurityService securityService = new SecurityService();
            var result = securityService.Authenticate(model);

            try
            {
                if (result)
                {
                    MyLogger1.GetInstance().Info(" Exit LoginController.Login() with login passing");
                    return View("LoginPassed", model);
                }
                else
                {
                    MyLogger1.GetInstance().Warning(" Exit LoginController.Login() with login failing");
                    return View("LoginFailed");
                }
            }
            catch (System.Exception e)
            {
                MyLogger1.GetInstance().Error(" Exception LoginController.Login()" + e.Message);
                throw;
            }
        }
    } 
}