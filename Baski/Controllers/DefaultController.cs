using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baski.Orm.Repositories;
using Baski.ViewModels;

namespace Baski.Controllers
{
    public class DefaultController : BaseController
    {
        //
        // GET: /Defaul/
        public ActionResult Index()
        {
            var posts = Repository.Articles.All().OrderByDescending(x=>x.Date);
            HomePageViewModel viewModel = new HomePageViewModel()
            {
                Articles = posts.Select(x=>new ArticleViewModel(x))
            };
            return View(viewModel);
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

        public ActionResult Footer()
        {
            FooterViewModel model = new FooterViewModel();
            model.Articles = Repository.Articles.All().OrderByDescending(x=>x.Date).Select(x=>new ArticleViewModel(x));
            return View(model);
        }

        public ActionResult LoadMore(int page)
        {
            var articles = Repository.Articles.All().ToList().Select(x=> new ArticleViewModel(x));
            ViewBag.Page = page + 1;
            return View("LoadMore", articles);
            /*var articles = Repository.Articles.All().Skip(3 * page).ToList();
            ViewData.Model = articles;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext,
                                                                         "_Article");
                var viewContext = new ViewContext(ControllerContext, viewResult.View,
                                             ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }*/
        }
    }
}