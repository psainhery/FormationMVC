using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace _2_DemoController.Controllers
{
   
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            //1-Une action peut retourner un autre vue
            //Action avec un resultat de type ViewResult
            /*return View("Contact");*/

            //2- Elle permet d'envoyer au client un ordre de redirection vers l'URL qui est dans le paramètre de la méthode
            //Action avec un résultat de type RedirectResult
            /*return Redirect("/Home/Contact");*/


            return View();

        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //3- En utilisant la methode RedirectToAction, l'action About retourne un type [RedirectToRouteResult]. 
            //return RedirectToAction("Index", "Test", new { nom = "Dawan", prenom = "Jehann" });
            
            //4- Fais la même chose que la methode précedente, en indiquant ici le nom de la route
            //Il prendra par defaut les valeurs qu'il y a dans les paramètres nom et prenom definis dans la route
            // return RedirectToRoute("ContactDetails");

            //5- La File retourne un type FilePathResult
            return File(Server.MapPath("~/Demo.txt"), "text/plain", "test.txt");


            /*return View();*/
        }

        public ActionResult Contact()
        {
            // ViewBag.Message = "Your contact page.";

            //return View();
            //10-
            //11-
            //12-
            //13- Action avec un resultat de type HttpNotfoundResult

            //return HttpNotFound();

            //14- Action avec un rsultat de type HttpStatusCodeResult

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Mauvaise requete");
            
        }
    }
}