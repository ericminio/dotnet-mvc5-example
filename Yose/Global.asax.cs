using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using System.Net.Http;

namespace Yose
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute (
                name: "Default",
                routeTemplate: "{controller}",

                defaults: new
                {
                    controller = "Home",
                    action = "Get",
                    id = UrlParameter.Optional
                }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure (RegisterRoutes);
        }
    }
}