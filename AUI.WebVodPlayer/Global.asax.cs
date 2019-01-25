using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using DatabaseAccess;

namespace AUI.WebVodPlayer
{
    public class Global : System.Web.HttpApplication
    {
        public static  AUIEntities database = new AUIEntities();
        protected void Application_Start(object sender, EventArgs e)
        {
        }
    }
}