using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_PassingToView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewData: un dictionnaire d'objets (cle, valeur), il contient donc des paires cle-valeur
            // chaque cle doit etre une chaine de caractere
            //ViewBag et ViewData transferent uniquement des donnees du controleur non l' inverse
            //ViewBag: C' est le meme objet que ViewData
            //ViewBag et ViewData: leur cycle de vue est limitee a la requete - une fois la reponse 
            //envoye vers le navigateur, ces 2 objets sont remis a zero par le serveur

            //if(id.HasValue)
            //{
            //    ViewData["ID"] = id.Value;
            //}else
            //{
            //    ViewData["ID"] = 0;
            //}

            //if (id.HasValue)
            //{
            //    ViewBag.Id = id.Value;
            //}
            //else
            //{
            //    ViewBag.Id = 0;
            //}

            /*
             * TempData est utilise pour transferer des data de la vue vers le controleur, et du controleur vers la vue
             * ou d'une  methode d'action vers une autre methode d'action de meme controleur ou d'un controleur different
             * TempData stocke les donnes temporairement et les supprime automatiquement apres avoir recup une valeur 
             * Nous allons voir bien que TempData supprime une key-val, une fois recup, nous pouvons tuoujours la conserver
             * pour la demande suivante en appelant la methode TempData.Keep().
             */
            //if (id.HasValue)
            //{
            //    TempData["ID"] = id.Value;
            //}
            //else
            //{
            //    TempData["ID"] = 0;
            //}

            //TempData.Keep(); //maintenir le conte

            return View();
        }
        [HttpPost]
        public ActionResult Index(string nom)
        {
            ViewBag.Nom = nom;
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
    }
}