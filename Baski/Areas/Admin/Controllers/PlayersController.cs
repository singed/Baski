using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baski.Configuration;
using Baski.Orm.Models;

namespace Baski.Areas.Admin.Controllers
{
    public class PlayersController : AdminBaseController
    {
        public ActionResult Index()
        {
            var playersList = Repository.Players.All();

            return View("List", playersList);
        }

        public ActionResult Create()
        {
            return View();
        }

        //
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName, LastName, Birthdate, Height, Weight,Position,Description,ImageUrl,VkontakteUrl,FacebookUrl,InstagramUrl,TwitterUrl")] Player player)
        {
            try
            {
                string fileName = string.Empty;
                if (Request.Files.Count > 0 && !string.IsNullOrEmpty(Request.Files[0].FileName))
                {
                    string path = Server.MapPath(AppSettings.PlayersImagesPath);
                    fileName = Path.GetFileName(Request.Files[0].FileName);
                    Request.Files[0].SaveAs(path + fileName);
                }
                if (ModelState.IsValid)
                {
                    int? id = Repository.Players.Insert(new
                    {
                        Firstname = player.FirstName,
                        Lastname = player.LastName,
                        Birthdate = player.Birthdate,
                        Height = player.Height,
                        Weight = player.Weight,
                        Position = player.Position,
                        VkontakteUrl = player.VkontakteUrl,
                        FacebookUrl = player.FacebookUrl,
                        InstagramUrl = player.InstagramUrl,
                        TwitterUrl = player.TwitterUrl,
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
            var player = Repository.Players.Get(id);
            return View(player);
        }

        //
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "FirstName, LastName, Birthdate, Height, Weight," +
                                                   "Position,Description,ImageUrl,VkontakteUrl,FacebookUrl," +
                                                   "InstagramUrl,TwitterUrl")] Player player)
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

                Repository.Players.Update(id, new
                {
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    Birthdate = player.Birthdate,
                    Height = player.Height,
                    Weight = player.Weight,
                    Position = player.Position,
                    VkontakteUrl = player.VkontakteUrl,
                    FacebookUrl = player.FacebookUrl,
                    InstagramUrl = player.InstagramUrl,
                    TwitterUrl = player.TwitterUrl,
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