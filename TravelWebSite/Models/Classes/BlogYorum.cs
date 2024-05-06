using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelWebSite.Models.Classes;

namespace TravelWebSite.Models.Classes
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<comments> Deger2 { get; set; }
    }
}