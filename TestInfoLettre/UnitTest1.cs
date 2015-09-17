using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PremiereApp.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using PremiereApp.Models;
using System.Data.Entity;
using System.Linq;

namespace TestInfoLettre
{
    [TestClass]
    public class TestDuControlleurGestionSub
    {

        [TestMethod]
        public void TesterAffichageDePageDeCreationQuandOnAppelleHomeSAbonner()
        {
            HomeController c = new HomeController();
            ViewResult result = (ViewResult) c.Abonnement();

            DbSet<Category> data = 
                (DbSet <Category>) result.Model;


            Assert.AreEqual(3, data.Count(), "Nombre de categories n'est pas 0");
            Assert.AreEqual("", result.ViewName);
        }

        [TestMethod]
        public void AjouterUnAbonnementAvecActionEdit()
        {

            GestionSubController controller = new GestionSubController();
        }
    }
}
