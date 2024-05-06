using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Tokenizer;
using TravelWebSite.Models.Classes;

namespace TravelWebSite.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        BlogYorum by = new BlogYorum();
        public ActionResult blog(int id)
        {
            //var blogcek = c.Blogs.Where(x =>x.ID == id).ToList();

            by.Deger1 = c.Blogs.Where( x => x.ID == id).ToList();
            
            return View(by);
        }
    }
    

}