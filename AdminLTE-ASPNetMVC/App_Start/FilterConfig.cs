﻿using System.Web;
using System.Web.Mvc;

namespace AdminLTE_ASPNetMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
