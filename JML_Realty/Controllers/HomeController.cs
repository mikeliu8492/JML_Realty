using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JML_Realty.Controllers
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
            ViewBag.Message = "Your contact page";
            return View();
        }

        public ActionResult Tour()
        {
            ViewBag.Message = "Tour Page";

            List<string> rooms = new List<string>() {"~/Content/Images/ExtShots/ext_shot1.jpg", "~/Content/Images/ExtShots/ext_shot2.jpg", "~/Content/Images/ExtShots/ext_shot3.jpg" };
            List<List<string>> tour = new List<List<string>>() { rooms };

            return View(tour);
        }

        public ActionResult FAQ()
        {
            return View();
        }
    }
}