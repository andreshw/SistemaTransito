﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SistemaTransito.Web.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Establece JSON como formato por defecto.
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
