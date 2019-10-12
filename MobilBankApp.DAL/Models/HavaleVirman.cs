using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilBankApp.DAL.Models
{
    public class HavaleVirman
    {
        public int Id { get; set; }
        public string GonderenHesapNo { get; set; }
        public string AliciHesapNo { get; set; }
        public int GonderenHesapEkno { get; set; }
        public int AliciHesapEkno { get; set; }
        public decimal Miktar { get; set; }
        public DateTime Time { get; set; }
        public string Tur { get; set; }
    }
}
