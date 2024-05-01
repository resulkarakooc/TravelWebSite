using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebSite.Models.Classes;

namespace TravelWebSite.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var degerler = c.hakkımızdaTests.ToList();
            return View(degerler);
        }
    }
}