﻿using System.Web;
using System.Web.Mvc;

namespace COMP229_F2016_Lesson8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
