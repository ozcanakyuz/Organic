using Organic.DataAccessLayer.Abstract;
using Organic.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organic.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly OrganicContext _context;
        public GenericRepository(OrganicContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var entity = _context.Categories.Find(id);
            if (entity != null)
            {
                _context.Categories.Remove(entity);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı.");
            }

        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _context.Set<T>().ToList()[id];
            //return _context.Set<T>().Find(id);
        }
        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
