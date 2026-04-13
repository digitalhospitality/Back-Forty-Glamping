using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace backfortyglamping2026
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("SendGetintouchmail", "SendGetintouchmail", new { controller = "EndUser", action = "SendGetintouchmail" });
            routes.MapRoute("SendContactUsmail", "SendContactUsmail", new { controller = "EndUser", action = "SendContactUsmail" });
            routes.MapRoute("NewsLetterExport", "download-newsletter-excel", new { controller = "EndUser", action = "NewsLetterExport" });
            
            routes.MapRoute("aboutus", "about", new { controller = "EndUser", action = "aboutus" });
            routes.MapRoute("amenities", "amenities", new { controller = "EndUser", action = "amenities" });
            routes.MapRoute("contactus", "contact", new { controller = "EndUser", action = "contactus" });
            routes.MapRoute("dining", "dining", new { controller = "EndUser", action = "dining" });
            routes.MapRoute("domes", "domes", new { controller = "EndUser", action = "domes" });
            routes.MapRoute("gallery", "gallery", new { controller = "EndUser", action = "gallery" });
            routes.MapRoute("localarea", "local-area", new { controller = "EndUser", action = "localarea" });
            routes.MapRoute("policies", "policies", new { controller = "EndUser", action = "policies" });
            routes.MapRoute("PrivacyPolicy", "privacy-policy", new { controller = "EndUser", action = "PrivacyPolicy" });
            routes.MapRoute("Sitemap", "sitemap", new { controller = "EndUser", action = "Sitemap" });
            //routes.MapRoute("Concierge", "concierge", new { controller = "EndUser", action = "Concierge" });

            routes.MapRoute(name: "Default", url: "", defaults: new { controller = "EndUser", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute("ErrorPage404", "{*url}", new { controller = "EndUser", action = "ErrorPage404" });
        }
    }
}