using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebSite.Models.Classes;

namespace TravelWebSite.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Urunlers.ToList();
            return View(degerler);
        }

        
        public ActionResult addsepet(int id)
        {
            
            return View("Index");
        }
    }
}