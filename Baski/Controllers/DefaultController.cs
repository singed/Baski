using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baski.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Defaul/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Roster()
        {
            return View();
        }

        public ActionResult Video()
        {
            return View();
        }

        public ActionResult Statistics()
        {
            return View();
        }
    }
}