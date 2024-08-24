using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Gft.B3.Desafio.Api
{
    public class RouteConfig
    {
        //Apenas para redirecionar sempre para home ao abrir o projeto. 
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var context = HttpContext.Current;
            var requestPath = context.Request.Url.AbsolutePath;

            
            if (!requestPath.Equals("/") && !requestPath.StartsWith("/Home", StringComparison.OrdinalIgnoreCase))
            {
                context.Response.Redirect("~/Home/Index");
            }
        }
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
