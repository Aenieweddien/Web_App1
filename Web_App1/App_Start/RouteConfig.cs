using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web_App1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Account",
               url: "Account/{action}/{id}",
               defaults: new { controller = "Account", action = "Index", id = UrlParameter.Optional },
               new[] { "Web_App1.Controllers" }
           );
            /////////
            routes.MapRoute(
               name: "SidebarPartial",
               url: "Page/SidebarPartial",
               defaults: new { controller = "Pages", action = "SidebarPartial", id = UrlParameter.Optional },
               new[] { "Web_App1.Controllers" }
           );
            /////////
            routes.MapRoute(
               name: "Cart",
               url: "Cart/{action}/{id}",
               defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional },
               new[] { "Web_App1.Controllers" }
           );
            ///
            routes.MapRoute(
               name: "Shop",
               url: "Shop/{action}/{name}",
               defaults: new { controller = "Shop", action = "Index", name = UrlParameter.Optional, id = UrlParameter.Optional },
               new[] { "Web_App1.Controllers" }
           );
            routes.MapRoute(
               name: "Page",
               url: "{page}",
               defaults: new { controller = "Pages", action = "Index", id = UrlParameter.Optional },
               new[] { "Web_App1.Controllers" }
           );
            routes.MapRoute(
               name: "Default",
               url: "",
               defaults: new { controller = "Pages", action = "Index", id = UrlParameter.Optional },
               new[] { "Web_App1.Controllers" }
           );
            routes.MapRoute(
              name: "PagesMenuPartial",
              url: "Page/PagesMenuPartial",
              defaults: new { controller = "Pages", action = "PagesMenuPartial", id = UrlParameter.Optional },
              new[] { "Web_App1.Controllers" }
          );

            routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
