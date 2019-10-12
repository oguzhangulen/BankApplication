using MobilBankApp.DAL.Context;
using MobilBankApp.DAL.Infrastructure;
using MobilBankApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilBankApp.DAL.Implementation
{
    public class HesapRepository : IHesapRepository, IDisposable
    {
        private readonly DataContext _context = new DataContext();
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IEnumerable<Hesap> GetAll()
        {
            try
            {
                return _context.Hesaps.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public Hesap GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Hesap GetByTC(string Tc)
        {
            try
            {
                return _context.Hesaps.FirstOrDefault(s => s.TCKN == Tc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool Insert(Hesap obj)
        {
            try
            {
                if (obj != null)
                {
                    _context.Entry(obj).State = EntityState.Added;
                    Save();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public bool Update(Hesap obj)
        {
            try
            {
                if (obj != null)
                {
                    _context.Entry(obj).State = EntityState.Modified;
                    Save();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        bool IRepository<Hesap>.Insert(Hesap obj)
        {
            throw new NotImplementedException();
        }

        bool IRepository<Hesap>.Update(Hesap obj)
        {
            throw new NotImplementedException();
        }
    }
}
