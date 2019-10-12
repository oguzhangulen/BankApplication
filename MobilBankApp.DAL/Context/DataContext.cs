using MobilBankApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilBankApp.DAL.Context
{
    public class DataContext:DbContext
    {
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Hesap> Hesaps { get; set; }
        public DbSet<HavaleVirman> HavaleVirmans { get; set; }
        public DataContext():base(@"Data Source=DESKTOP-J61RGUJ\OGUZHANGULEN;Initial Catalog=BankApp; Integrated Security=true;Trusted_Connection=true;")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, MobilBankApp.DAL.Migrations.Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hesap>().HasKey(u => new
            {
                u.HesapNo,
                u.EkNo
            });
        }
    }
}
