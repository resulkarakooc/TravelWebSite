using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelWebSite.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Users> Userss { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<HakkımızdaTest> hakkımızdaTests  { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Satıslar> satıslars { get; set; }
        public DbSet<Blog> Blogs { get; set; }

    }
}