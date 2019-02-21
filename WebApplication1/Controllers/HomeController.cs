using SportsStore.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace SportsStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration = 2, Location = OutputCacheLocation.Server)]
        public ActionResult Index()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Placeholder", "Placeholder");
            return View(data);
        }
    }
}