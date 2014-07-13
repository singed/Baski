using System;
using System.Collections.Generic;
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
    }
}