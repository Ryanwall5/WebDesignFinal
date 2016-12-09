using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace RyansAppService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\Ryanwall5\Documents\Visual Studio 2015\Projects\Lab6_RyanWall_WebDesign\Lab6_RyanWall_WebDesign\App_Data");
        }
    }
}
