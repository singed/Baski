using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baski.Orm.Models;
using Baski.Orm.Repositories;

namespace Baski.Areas.Admin.Controllers
{
    public class ArticleController : AdminBaseController
    {
        //
        // GET: /Admin/Article/
        public ActionResult Index()
        {
            var articlesList = Repository.Articles.All();
            return View("List", articlesList);
        }

        //
        // GET: /Admin/Article/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/Article/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/Article/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Title, Text, HasVideo, ResourceUrl")] Article article)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    article.Date = DateTime.Now;
                    int? id = Repository.Articles.Insert(new
                    {
                        Date= article.Date,
                        Title = article.Title,
                        Text= article.Text,
                        HasVideo = article.HasVideo,
                        ResourceUrl = article.ResourceUrl
                    });
                    return RedirectToAction("Index");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/Article/Edit/5
        public ActionResult Edit(int id)
        {
            var article = Repository.Articles.Get(id);
            return View(article);
        }

        //
        // POST: /Admin/Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "Title, Text, Date, HasVideo, ResourceUrl")] Article article)
        {
            try
            {
                Repository.Articles.Update(id, new
                {
                    Date = DateTime.Now,
                    Title = article.Title,
                    Text = article.Text,
                    HasVideo = article.HasVideo,
                    ResourceUrl = article.ResourceUrl
                });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/Article/Delete/5
        public ActionResult Delete(int id)
        {
            Repository.Articles.Delete(id);
            return RedirectToAction("Index");
        }

        //
        // POST: /Admin/Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
