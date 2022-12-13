using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public T GetListByID(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(T entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
