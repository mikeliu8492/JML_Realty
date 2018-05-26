using JML_Realty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;


namespace JML_Realty.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Form()
        {
            ViewBag.Status = "We Are Still Working on the Admin Portal for Reviewing Messages!";
            ContactEmail email = new ContactEmail();
            return View(email);
        }

        [HttpPost]
        public ActionResult Form(ContactEmail obj)
        {
            ViewBag.Status = "";

            if (!ModelState.IsValid)
            {
                ViewBag.Status = "You Entered Invalid Information.  Please see below for corrections.";
                return View(obj);
            }

            ViewBag.Status = "We Are Still Working on the Admin Portal for Reviewing Messages!  Be Patient!";
            return View();
        }
    }
}