using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1_DemoMVC
{
    public class RouteConfig
    {
        //URL : /X/Y/Z
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Les routes personnalisée doivent être définies avant la route par defaut 
            routes.MapRoute(
              name: "Hello",
              url: "Hello/{action}/{nom}/{prenom}",
              new { controller = "Hello", action = "SayHello", nom = UrlParameter.Optional, prenom = UrlParameter.Optional });

            routes.MapRoute(
                name: "RouteCalculatrice",
                url: "{controller}/{action}/{nb1}/{nb2}",
                defaults: new { controller = "Home", action = "Index", nb1 = UrlParameter.Optional, nb2 = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
