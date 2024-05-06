namespace TravelWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resul : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        mail = c.String(),
                        name = c.String(),
                        lastname = c.String(),
                        contact = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HakkımızdaTest",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tisim = c.String(),
                        TgorselUrl = c.String(),
                        Taciklama = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Satıslar",
                c => new
                    {
                        SatısID = c.Int(nullable: false, identity: true),
                        Adet = c.Int(nullable: false),
                        totalTutar = c.Int(nullable: false),
                        urunID_urunID = c.Int(),
                    })
                .PrimaryKey(t => t.SatısID)
                .ForeignKey("dbo.Urunlers", t => t.urunID_urunID)
                .Index(t => t.urunID_urunID);
            
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        urunID = c.Int(nullable: false, identity: true),
                        urunName = c.String(),
                        urunGorselUrl = c.String(),
                        fiyat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.urunID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satıslar", "urunID_urunID", "dbo.Urunlers");
            DropIndex("dbo.Satıslar", new[] { "urunID_urunID" });
            DropTable("dbo.Users");
            DropTable("dbo.Urunlers");
            DropTable("dbo.Satıslar");
            DropTable("dbo.HakkımızdaTest");
            DropTable("dbo.Contacts");
        }
    }
}
