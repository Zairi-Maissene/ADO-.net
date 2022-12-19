using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ado.net
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}",
                defaults: new { controller = "Home", action = "Index"}
            );
            routes.MapRoute(
               name: "AllPeople",
               url: "Person/All",
               defaults: new { controller = "Person", action = "All" }
               );
            routes.MapRoute(
              name: "Search",
              url: "Person/Search",
              defaults: new { controller = "Person", action = "Search" }
              );
            routes.MapRoute(
             name: "SearchModal",
             url: "Person/Search/getByFirstNameAndCountry",
             defaults: new { controller = "Person", action = "getByFirstNameAndCountry" }
             );
            routes.MapRoute(
                name: "PersonDetails",
                url: "Person/{id}",
                defaults: new { controller ="Person", action = "getById",id = UrlParameter.Optional }
               );
           
        }
    }
}
