using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baski.Authentication;
using Baski.Configuration;
using Baski.Orm.Models;
using Baski.Orm.Repositories;

namespace Baski.Areas.Admin.Controllers
{
    [CustomAuthorize(Roles = "Administrator")]
    public class ArticlesController : AdminBaseController
    {
        //
        // GET: /Admin/Article/
        public ActionResult Index()
        {
            var articlesList = Repository.Articles.All().OrderByDescending(x=>x.Date);

            return View("List", articlesList);
        }

        //
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        public ActionResult Create()
        {
            return View();
        }

        //
        [HttpPost]
        public ActionResult Create([Bind(Include = "Title, Text, Date, VideoUrl,ImageUrl")] Article article)
        {
            try
            {
                string fileName = string.Empty;
                if (Request.Files.Count > 0 && !string.IsNullOrEmpty(Request.Files[0].FileName))
                {
                    string path = Server.MapPath(AppSettings.ArticlesImagesPath);
                    fileName = Path.GetFileName(Request.Files[0].FileName);
                    Request.Files[0].SaveAs(path + fileName);
                }
                if (ModelState.IsValid)
                {
                    int? id = Repository.Articles.Insert(new
                    {
                        Date= article.Date,
                        Title = article.Title,
                        Text= article.Text,
                        VideoUrl = article.VideoUrl,
                        ImageUrl = fileName
                    });
                    return RedirectToAction("Index");
                }

                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("error", ex.Message);
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
        public ActionResult Edit(int id, [Bind(Include = "Title, Text, Date, VideoUrl, ImageUrl")] Article article)
        {
            try
            {
                string fileName = string.Empty;
                if (!string.IsNullOrEmpty(Request.Form["ImageFileName"]))
                {
                    fileName = Request.Form["ImageFileName"];
                }

                if (Request.Files.Count > 0 && !string.IsNullOrEmpty(Request.Files[0].FileName))
                {
                    string path = Server.MapPath(AppSettings.ArticlesImagesPath);
                    fileName = Path.GetFileName(Request.Files[0].FileName);
                    Request.Files[0].SaveAs(path + fileName);
                }
                
                Repository.Articles.Update(id, new
                {
                    Date = article.Date,
                    Title = article.Title,
                    Text = article.Text,
                    VideoUrl = article.VideoUrl,
                    ImageUrl = fileName
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
