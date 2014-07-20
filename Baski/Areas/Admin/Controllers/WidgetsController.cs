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
    public class WidgetsController : AdminBaseController
    {
        //
        public ActionResult Index()
        {
            var widgetsList = Repository.Widgets.All();

            return View("List", widgetsList);
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
        public ActionResult Create([Bind(Include = "Name, InnerHtml")] Widget widget)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int? id = Repository.Widgets.Insert(new
                    {
                        Name = widget.Name,
                        InnerHtml = widget.InnerHtml,
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
        public ActionResult Edit(int id)
        {
            var widget = Repository.Widgets.Get(id);
            return View(widget);
        }

        //
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "Name, InnerHtml")] Widget widget)
        {
            try
            {
                Repository.Widgets.Update(id, new
                {
                    Name = widget.Name,
                    InnerHtml = widget.InnerHtml,
                  
                });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        public ActionResult Delete(int id)
        {
            Repository.Articles.Delete(id);
            return RedirectToAction("Index");
        }

        //
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
