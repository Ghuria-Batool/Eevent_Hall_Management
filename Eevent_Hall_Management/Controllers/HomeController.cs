using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eevent_Hall_Management.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact_Us()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult About_Us()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Events()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Menus()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Venues()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Upcoming_Events
            ()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}