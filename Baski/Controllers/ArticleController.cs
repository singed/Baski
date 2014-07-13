using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baski.Orm.Models;
using Baski.ViewModels;

namespace Baski.Controllers
{
    public class ArticleController : BaseController
    {
        //
        // GET: /Article/
        public ActionResult Index(int id)
        {
            Article article = Repository.Articles.Get(id);
            return View(new ArticleViewModel(article));
        }
	}
}