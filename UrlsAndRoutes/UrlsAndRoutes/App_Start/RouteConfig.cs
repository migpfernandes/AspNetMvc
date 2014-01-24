using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.RouteExistingFiles = true;

            routes.IgnoreRoute("Content/{filename}.html");

            routes.MapRoute("DiskFile", "Content/StaticContent.html",
                new
                {
                    controller = "Customer",
                    action = "List",
                });

            routes.MapRoute("ChromeRoute", "{*catchall}",
                new { controller = "Home", action = "Index" },
                new {
                    customConstraint = new UserAgentConstraint("Chrome")
                },
                new[] { "URLsAndROutes.Controllers" });

            //routes.MapRoute("AddControllerRoute", "Home/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new
            //    {
            //        controller = "^H.*",
            //        action = "^Index$|^About$",
            //        httpMethod = new HttpMethodConstraint("GET")
            //    },
            //    new[] { "URLsAndROutes.Controllers" });


            //routes.MapRoute("AddControllerRoute", "Home/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new { controller = "^H.*",action = "^Index$|^About$"},
            //    new[] { "URLsAndROutes.Controllers" });


            //Route myRoute = routes.MapRoute("AddControllerRoute", "Home/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new[] { "URLsAndROutes.AdditionalControllers" });

            //myRoute.DataTokens["UseNamespaceFallback"] = false;

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "URLsAndROutes.Controllers" });

            //routes.MapRoute("ShopSchema", "Shop/{action}",
            //    new { controller = "Home" });

            //routes.MapRoute("", "X{controller}/{action}");

            //routes.MapRoute("MyRoute", "{controller}/{action}",
            //    new { controller = "Home", action = "Index" });

            //routes.MapRoute("", "Public/{controller}/{action}",
            //    new { controller = "Home", action = "Index" });
        }
    }
}