using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.MessageHandlers.Add(new Controllers.Utils.ControllerHandler());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "login",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
