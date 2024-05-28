using Microsoft.AspNetCore.Routing;
using System.Web.Mvc;

public class RouterConfig
{
    public static void RegisterRoutes(RouteBuilder routes)
    {
        routes.MapRoute(
            name: "Default",
            template: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index1", id = UrlParameter.Optional }
        );
    }
}