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
    public class MusteriRepository : IMusteriRepository, IDisposable
    {
        private readonly DataContext _context = new DataContext();
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IEnumerable<Musteri> GetAll()
        {
            try
            {
                return _context.Musteris.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public Musteri GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Musteri GetByTC(string TC)
        {
            try
            {
                return _context.Musteris.FirstOrDefault(s => s.TCKN == TC);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool Insert(Musteri obj)
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

        public bool Update(Musteri obj)
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
    }
}
