using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilBankApp.DAL.Models
{
    public class Musteri
    {
        [Key]
        public string TCKN { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
        public string TelNo { get; set; }
        public string EPosta { get; set; }

        public ICollection<Hesap> Hesaps { get; set; }
    }
}
