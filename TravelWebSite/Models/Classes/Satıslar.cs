using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebSite.Models.Classes
{
    public class Satıslar
    {
        [Key]
        public int SatısID { get; set; }
        public Users UserID { get; set; }
        public virtual Urunler urunID { get; set; }
        public int Adet { get; set; }
        public int totalTutar { get; set; }
    }
}