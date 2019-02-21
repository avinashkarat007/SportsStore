using SportsStore.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessFirstForm(string name)
        {
            System.Diagnostics.Debug.WriteLine("Name: {0}", (object)name);
            SessionStateHelper.Set(SessionStateKeys.NAME, name);
            return View("SecondForm");
        }

        [HttpPost]
        public ActionResult CompleteForm(string country)
        {
            System.Diagnostics.Debug.WriteLine("Country: {0}", (object)country);
            // in a real application, this is where the call to create the
            // new user account would be

            ViewBag.Name = SessionStateHelper.Get(SessionStateKeys.NAME).ToString();
            ViewBag.Country = country;
            return View();
        }
    
    }
}