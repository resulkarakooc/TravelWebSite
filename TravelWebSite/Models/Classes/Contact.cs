using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebSite.Models.Classes
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string mail { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string contact { get; set; }
    }
}