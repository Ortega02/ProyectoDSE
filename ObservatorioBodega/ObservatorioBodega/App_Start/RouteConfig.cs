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
<<<<<<< HEAD
=======

        //para probar funcion debido a fallo del enrutador de abajo
>>>>>>> c790baf0d4c6717e92c51ac1693acd053b89a33c
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
<<<<<<< HEAD
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

          routes.MapRoute(
          name: "Login",
          url: "Login/{action}/{id}",
          defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
);
        }
=======
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        //        public static void RegisterRoutes(RouteCollection routes)
        //        {
        //            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


        //            routes.MapRoute(
        //               name: "Menus",
        //               url: "{controller}/{action}/{id}",
        //               defaults: new { controller = "Menus", action = "Index", id = UrlParameter.Optional }
        //            );

        //            routes.MapRoute(
        //               name: "Documentos",
        //               url: "{controller}/{action}/{id}",
        //               defaults: new { controller = "Documentos", action = "Index", id = UrlParameter.Optional }
        //            );

        //            //RUTA PARA COLABORADORES
        //            routes.MapRoute(
        //            name: "Colaboradores",
        //            url: "{controller}/{action}/{id}",
        //            defaults: new { controller = "Colaboradores", action = "Index", id = UrlParameter.Optional }
        //);
        //        }
>>>>>>> c790baf0d4c6717e92c51ac1693acd053b89a33c
    }
}
