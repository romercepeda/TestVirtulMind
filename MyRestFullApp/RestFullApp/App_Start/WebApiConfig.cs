using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RestFullApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "MyRestFullApp/{controller}/{action}/{id}",
                //Se modifico el ruteo de los API para cumplir con el requerimiento de http://localhost:8080/MyResftfullApp/Cotizacion/MONEDA,
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
