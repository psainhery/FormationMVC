using _5_DemoViewRazor.Models;
using _5_DemoViewRazor.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_DemoViewRazor.Controllers
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
            Employe emp = new Employe() { Id = 1, Nom = "Dawan", Prenom = "Jehann" };
            Produit p = new Produit() { Id = 1 };
            ProdEmploye pe = new ProdEmploye();
            pe.Produit = p;
            pe.Employe = emp;

            return View(pe);
        }

        //Test pour commit -push
    }
}