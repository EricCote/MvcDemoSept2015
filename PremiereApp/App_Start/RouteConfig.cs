using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PremiereApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "DireBonjour",
               url: "bonjour/{prenom}/{nom}/{id}",
               defaults: new
               { controller = "Home",action = "Bonjour",
                   prenom = "Joe",
                   nom = "Wow",
                   id = 0
               }
           );

            routes.MapRoute(
                name: "Default",
                url: "{langue}/{controller}/{action}/{id}",
                defaults: new { langue = "en", controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { langue = "en|fr"}
            );



        }
    }
}
