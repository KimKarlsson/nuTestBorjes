using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using nuTestBorje.Models;

namespace nuTestBorje.Controllers
{
    public class UrlModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UrlModels
        public ActionResult Index()
        {
            return View(db.UrlModels.ToList());
        }

        // GET: UrlModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrlModel urlModel = db.UrlModels.Find(id);
            if (urlModel == null)
            {
                return HttpNotFound();
            }
            return View(urlModel);
        }

        // GET: UrlModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UrlModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,ActuallUrl,description,UploadDate,Placing,Type")] UrlModel urlModel)
        {
            if (ModelState.IsValid)
            {
                db.UrlModels.Add(urlModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(urlModel);
        }

        // GET: UrlModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrlModel urlModel = db.UrlModels.Find(id);
            if (urlModel == null)
            {
                return HttpNotFound();
            }
            return View(urlModel);
        }

        // POST: UrlModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ActuallUrl,description,UploadDate,Placing,Type")] UrlModel urlModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(urlModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(urlModel);
        }

        // GET: UrlModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrlModel urlModel = db.UrlModels.Find(id);
            if (urlModel == null)
            {
                return HttpNotFound();
            }
            return View(urlModel);
        }

        // POST: UrlModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UrlModel urlModel = db.UrlModels.Find(id);
            db.UrlModels.Remove(urlModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
