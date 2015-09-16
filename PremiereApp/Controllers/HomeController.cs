using PremiereApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremiereApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public string Bonjour(string prenom, string nom, string id)
        {
            var personne = new { Prenom = prenom, Nom = nom };

            return string.Format("Bonjour {0} {1}. Votre id: {2}",
                    personne.Prenom,
                    personne.Nom,
                    id);


        }

        [HttpGet]
        public ActionResult Abonnement()
        {
            NewsContext db = new NewsContext();
            var data = db.Categories;

            return View(data);
        }

        [HttpPost]
        public ActionResult Abonnement(Subscriber abonne)
        {
            abonne.CreationDate = DateTime.Now;
            NewsContext db = new NewsContext();

            foreach (Category cat in db.Categories)
            {
                if (Request.Params[cat.CategoryName] != null)
                {
                    if (abonne.Categories == null)
                    {
                        abonne.Categories = new List<Category>();
                    }
                    abonne.Categories.Add(cat);
                }
            }
            db.Subscribers.Add(abonne);
            db.SaveChanges();

            return View("merci", abonne);
        }
    }
}