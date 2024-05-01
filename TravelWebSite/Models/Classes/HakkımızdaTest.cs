using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebSite.Models.Classes
{
    public class HakkımızdaTest
    {
        [Key]
        public int ID { get; set; }
        public String Tisim { get; set; }
        public String TgorselUrl { get; set; }
        public String Taciklama { get; set; }
    }
}