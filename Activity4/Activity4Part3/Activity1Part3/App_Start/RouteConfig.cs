using System.Web.Mvc;
using System.Web.Routing;

namespace Activity1Part3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Login",
                url: "Protected",
                defaults: new { controller = "Login", action = "Protected", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Protected",
                url: "Login",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Test",
                url: "Login",
                defaults: new { controller = "Test", action = "Index", id = UrlParameter.Optional }
                );
        }
    }
}
