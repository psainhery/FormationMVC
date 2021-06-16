using _1_DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_DemoMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
/*        public ActionResult Index()
        {
            return View();
        }*/

        public ActionResult SayHello(string nom, string prenom)
        {
            /*     ViewBag.Nom = nom;
                 ViewBag.Prenom = prenom;*/
            Personne p = new Personne();
            p.Nom = nom;
            p.Prenom = prenom;

            return View(p);
        }
    }
}