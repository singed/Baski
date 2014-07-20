using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baski.Configuration;

namespace Baski.Controllers
{
    public class WidgetController : BaseController
    {
        //
        // GET: /Widget/
        public ActionResult SideBar()
        {
            var widget = Repository.Widgets.Get(int.Parse(AppSettings.SidebarWidgetId));
            return View(widget);
        }
	}
}