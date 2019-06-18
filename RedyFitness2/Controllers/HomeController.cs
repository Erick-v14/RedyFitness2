using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedyFitness2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult myProfile()
        {
            return View();
        }
       
        public ActionResult History()
        {
            return View();
        }

        public ActionResult Workout()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Erick Valle";

            return View();
        }
    }
}