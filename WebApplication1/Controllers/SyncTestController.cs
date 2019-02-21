using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class SyncTestController : Controller
    {
        // GET: SyncTest
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(NoStore = true, Duration = 0)]
        public string GetMessage(int id)
        {
            return string.Format("Message: {0}", id);
        }
    }
}