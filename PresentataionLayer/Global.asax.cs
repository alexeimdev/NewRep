using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PresentataionLayer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CustomViewEngine());
        }

        public class CustomViewEngine : RazorViewEngine
        {
            public CustomViewEngine()
            {
                var viewLocations = new[]
                {
                    "~/Presentation/Views/{1}/{0}.cshtml",
                    "~/Presentation/Views/Shared/{0}.cshtml"
                };

                this.PartialViewLocationFormats = viewLocations;
                this.ViewLocationFormats = viewLocations;
            }
        }

    }
}
