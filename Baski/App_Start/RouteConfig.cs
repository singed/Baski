using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Baski
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Article",
              url: "Article/{id}",
              defaults: new { controller = "Article", action = "Index", id=UrlParameter.Optional }
          );
            routes.MapRoute(
               name: "Statistics",
               url: "Statistics",
               defaults: new { controller = "Default", action = "Statistics" }
           );
            routes.MapRoute(
                name: "Video",
                url: "Video",
                defaults: new { controller = "Default", action = "Video" }
            );
            routes.MapRoute(
                name: "Roster",
                url: "Roster",
                defaults: new { controller = "Default", action = "Roster" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
