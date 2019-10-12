namespace MobilBankApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class og : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HavaleVirmen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GonderenHesapNo = c.String(),
                        AliciHesapNo = c.String(),
                        GonderenHesapEkno = c.Int(nullable: false),
                        AliciHesapEkno = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Time = c.DateTime(nullable: false),
                        Tur = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hesaps",
                c => new
                    {
                        HesapNo = c.String(nullable: false, maxLength: 128),
                        EkNo = c.Int(nullable: false),
                        BakiyeBilgi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AktiflikDurumu = c.Boolean(nullable: false),
                        TCKN = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.HesapNo, t.EkNo })
                .ForeignKey("dbo.Musteris", t => t.TCKN)
                .Index(t => t.TCKN);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        TCKN = c.String(nullable: false, maxLength: 128),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Sifre = c.String(),
                        Adres = c.String(),
                        TelNo = c.String(),
                        EPosta = c.String(),
                    })
                .PrimaryKey(t => t.TCKN);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hesaps", "TCKN", "dbo.Musteris");
            DropIndex("dbo.Hesaps", new[] { "TCKN" });
            DropTable("dbo.Musteris");
            DropTable("dbo.Hesaps");
            DropTable("dbo.HavaleVirmen");
        }
    }
}
