using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using travel.Models;

namespace travel.Controllers
{
    public class HomeController : Controller
    {

        // tengjum okkur við repository
        Repository db = new Repository();
        
        /// <summary>
        /// Hér kemur listi yfir allar tegundir ferða
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            var tripstype = db.GetTripsTypeList();

            return View(tripstype);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
