﻿using System.Web;
using System.Web.Mvc;

namespace FIT5032_MyCSS_Studio2
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
