using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebSite.Models.Classes
{
    public class Blog
    {

        [Key]
        public int ID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }
        public string BlogImage { get; set; }
    }
}
