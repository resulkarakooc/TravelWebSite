using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebSite.Models.Classes
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public String username { get; set; }
        public String userGorselUrl { get; set; }
        public String usermail { get; set; }
        public string userPassword { get; set; }
    }
}