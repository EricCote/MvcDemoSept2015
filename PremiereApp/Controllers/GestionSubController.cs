using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PremiereApp.Models;

namespace PremiereApp.Controllers
{
    public class GestionSubController : Controller
    {
        private NewsContext db = new NewsContext();

        // GET: GestionSub
        public ActionResult Index()
        {
            return View(db.Subscribers.ToList());
        }

        // GET: GestionSub/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                id = 1;
            }
            Subscriber subscriber = db.Subscribers.Find(id);
            if (subscriber == null)
            {
                return HttpNotFound();
            }
 
            //ViewData["listeCategories"] = categories;
            ViewBag.listeCategories = db.Categories.ToList();
            return View(subscriber);
        }

        // GET: GestionSub/Create
        public ActionResult Create()
        {
            Subscriber abonne = new Subscriber()
            {
                CreationDate = DateTime.Now
            };
            return View(abonne);
        }

        // POST: GestionSub/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubscriberId,Name,Email,CreationDate")] Subscriber subscriber)
        {
            if (ModelState.IsValid)
            {
                db.Subscribers.Add(subscriber);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subscriber);
        }

        // GET: GestionSub/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscriber subscriber = db.Subscribers.Find(id);
            if (subscriber == null)
            {
                return HttpNotFound();
            }
            ViewBag.listeCategories = db.Categories.ToList();
            return View(subscriber);
        }

        // POST: GestionSub/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Subscriber subscriber)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subscriber).State = EntityState.Modified;
                db.Entry(subscriber).Collection(p => p.Categories).Load();

                subscriber.Categories.Clear();
                foreach (Category cat in db.Categories)
                {
                    if (Request.Params["Categories."
                              + cat.CategoryName].StartsWith("true"))
                    {
                        subscriber.Categories.Add(cat);
                    }
                }

                db.SaveChanges();
                return RedirectToAction("Index");
            }
   
            ViewBag.listeCategories = db.Categories.ToList();
            return View(subscriber);
        }

   


        // GET: GestionSub/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscriber subscriber = db.Subscribers.Find(id);
            if (subscriber == null)
            {
                return HttpNotFound();
            }
            return View(subscriber);
        }

        // POST: GestionSub/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subscriber subscriber = db.Subscribers.Find(id);
            db.Subscribers.Remove(subscriber);
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
