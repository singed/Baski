using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baski.Authentication;

namespace Baski.Areas.Admin.Controllers
{
    [CustomAuthorize(Roles = "Administrator")]
    public class DefaultAdminController : Controller
    {
        //
        // GET: /Admin/Default/
        public ActionResult Index()
        {
            return View();
        }
	}
}