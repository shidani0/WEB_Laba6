﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LAB6
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Продукция в магазине",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Lab6", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
