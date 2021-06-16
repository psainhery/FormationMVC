using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_DemoMVC.Controllers
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


        public ActionResult Somme(int nb1, int nb2)
        {
            int resultat = (int)(nb1 + nb2);
            //ViewBag permet de transferer des données du contrôleur vers la vue
            //Ces données ne sont pas inclus dans le model
            ViewBag.Somme = resultat;
            return View();
        }

        public ActionResult Soustraction(int nb1, int nb2)
        {
            int resultat = (int)(nb1 - nb2);
            //ViewBag permet de transferer des données du contrôleur vers la vue
            //Ces données ne sont pas inclus dans le model
            ViewBag.Sub = resultat;
            return View();
        }

    }
}