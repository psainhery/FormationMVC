using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _4_DemoActionFilter.Filtres
{
    public class LogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace("OnActionExecuted", filterContext.RouteData);
            
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Trace("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Trace("OnResultExecuting", filterContext.RouteData);
        }


        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Trace("OnResultExecuted", filterContext.RouteData);
        }

        private void Trace(string methodName, RouteData routeData)
        {
            string actionName, contName;
            //Acceder au valeur de routage

            contName = routeData.Values["controller"].ToString();
            actionName = routeData.Values["action"].ToString();

            //Formatage de chaine en utilisant l' interpolation string.Format()

            string str = string.Format("1- Methode name = {0}, Controller Name = {1}, Action Name = {2}", methodName, contName, actionName);
            System.Diagnostics.Trace.WriteLine(str);

            //HttContext contient les informations de la requete en cours,
            HttpContext.Current.Response.Write("<br>" + str + "</br>" );
                
        }
    }
}