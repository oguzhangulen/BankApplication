using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilBankApp.DAL.Models
{
    public class Hesap
    {
        public string HesapNo { get; set; }
        public int EkNo { get; set; }
        public decimal BakiyeBilgi { get; set; }
        public bool AktiflikDurumu { get; set; }
        [ForeignKey("Musteri")]
        public string TCKN { get; set; }
        public Musteri Musteri { get; set; }
    }
}
