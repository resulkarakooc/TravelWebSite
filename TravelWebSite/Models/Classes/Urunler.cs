using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebSite.Models.Classes
{
    public class Urunler
    {
        [Key]
        public int urunID { get; set; }
        public string urunName { get; set;}
        public String urunGorselUrl { get; set; }
        public int fiyat { get; set; }
    }
}