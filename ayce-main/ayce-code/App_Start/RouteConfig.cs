using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ayce
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Dish Page",
               url: "dish/{slug}",
               defaults: new { controller = "ButterCMSPage", action = "Dish"}
           );

            routes.MapRoute(
               name: "Dish Feed",
               url: "dish",
               defaults: new { controller = "ButterCMSPage", action = "DishFeed"}
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ButterCMSPage", action = "Main", id = UrlParameter.Optional }
            );
        }
    }
}
