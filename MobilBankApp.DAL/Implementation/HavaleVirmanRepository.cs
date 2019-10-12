using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MobilBankApp.DAL.Infrastructure;
using MobilBankApp.DAL.Context;
using MobilBankApp.DAL.Models;

namespace MobilBankApp.DAL.Implementation
{
    public class HavaleVirmanRepository : IHavaleVirmanRepository, IDisposable
    {
        private readonly DataContext _context = new DataContext();
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IEnumerable<HavaleVirman> GetAll()
        {
            try
            {
                return _context.HavaleVirmans.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public HavaleVirman GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(HavaleVirman obj)
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

        public bool Update(HavaleVirman obj)
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
