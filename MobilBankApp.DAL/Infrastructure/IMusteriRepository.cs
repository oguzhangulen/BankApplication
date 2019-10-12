using MobilBankApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilBankApp.DAL.Infrastructure
{
    public interface IMusteriRepository:IRepository<Musteri>
    {
        Musteri GetByTC(string TC);
    }
}
