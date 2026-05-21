using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace backfortyglamping2026
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Url.ToString().ToLower().Contains("http://backfortyglamping.com/"))
            {
                HttpContext.Current.Response.Status = "301 Moved Permanently";
                HttpContext.Current.Response.StatusCode = 301;
                HttpContext.Current.Response.AddHeader("Location", Request.Url.ToString().ToLower().Replace("http://backfortyglamping.com/", "https://www.backfortyglamping.com/"));
            }


            if (HttpContext.Current.Request.Url.ToString().ToLower().Contains("https://backfortyglamping.com/"))
            {
                HttpContext.Current.Response.Status = "301 Moved Permanently";
                HttpContext.Current.Response.StatusCode = 301;
                HttpContext.Current.Response.AddHeader("Location", Request.Url.ToString().ToLower().Replace("https://backfortyglamping.com/", "https://www.backfortyglamping.com/"));
            }


            if (HttpContext.Current.Request.Url.ToString().ToLower().Contains("http://www.backfortyglamping.com"))
            {
                HttpContext.Current.Response.Status = "301 Moved Permanently";
                HttpContext.Current.Response.StatusCode = 301;
                HttpContext.Current.Response.AddHeader("Location", Request.Url.ToString().ToLower().Replace("http://www.backfortyglamping.com", "https://www.backfortyglamping.com"));
            }
        }
    }
}
