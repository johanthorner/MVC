﻿using System.Web;
using System.Web.Mvc;

namespace Labb4_Upg2_v2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
