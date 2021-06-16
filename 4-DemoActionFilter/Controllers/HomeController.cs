using _4_DemoActionFilter.Filtres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_DemoActionFilter.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [LogFilter]
        [AllowAnonymous]
        // permet d' authorizer l' acces a des utilisateurs non authentifier a des action individuelles
        [OutputCache(Duration = 10)] // Mise en cache du serveur pour 10 seconds du contenu de TempData
        public ActionResult Index()
        {
            TempData["Heure"] = DateTime.Now.ToLongTimeString();
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(true)]
        public ActionResult Index(string demo)
        {
            ViewBag.Demo = demo;
            return View();
        }

        //1- ce filtre gere les cas d' authorization
        //[Authorize] // Action  accessible uniquement par les user connectes
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
    }
}