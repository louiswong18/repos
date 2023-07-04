using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Headers;
using System.Web.Http.Cors;




namespace WebApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var cors = new EnableCorsAttribute(origins: "http://localhost:3000", headers: "*", methods: "*");
            config.EnableCors(cors);

            // Remove the XML formatter
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Set JSON as the default format
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));

            // Web API routes
            if (!config.Routes.ContainsKey("MS_attributerouteWebApi"))
            {
                config.MapHttpAttributeRoutes();
            }

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
