using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ObservatorioBodega
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
   name: "Documentos",
   url: "Documentos/{action}/{id}",
   defaults: new { controller = "Documentos", action = "Index", id = UrlParameter.Optional }
);
            //RUTA PARA COLABORADORES
            routes.MapRoute(
            name: "Colaboradores",
            url: "Colaboradores/{action}/{id}",
            defaults: new { controller = "Colaboradores", action = "Index", id = UrlParameter.Optional }
);
        }
    }
}
