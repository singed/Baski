using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baski.Orm.Repositories;

namespace Baski.Controllers
{
    public class DefaultController : BaseController
    {
        //
        // GET: /Defaul/
        public ActionResult Index()
        {
            var posts = Repository.Articles.All();

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