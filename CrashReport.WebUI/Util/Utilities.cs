using CrashReport.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrashReport.WebUI.Util
{
    public static class Utilities
    {
        public static string GetAppIconPath(Application app)
        {
            return string.Format("/Content/Images/AppIcons/{0}", app.IconFile);
        }
    }
}