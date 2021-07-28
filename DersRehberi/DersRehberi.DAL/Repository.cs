using DersRehberi.DAL.Interface;
using DersRehberi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.DAL
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        DersRehberiEntities context = new DersRehberiEntities();
        DbSet<T> _object;

        public Repository()
        {
            _object = context.Set<T>();
        }

        public int Add(T p)
        {
            var addedEntry = context.Entry(p);
            addedEntry.State = EntityState.Added;
            return context.SaveChanges();
        }

        public int Delete(T p)
        {
            var deletedEntry = context.Entry(p);
            deletedEntry.State = EntityState.Deleted;
            return context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.FirstOrDefault(filter);
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _object.ToList() : _object.Where(filter).ToList();
        }

        public int Update(T p)
        {
            var updatedEntry = context.Entry(p);
            updatedEntry.State = EntityState.Modified;
            return context.SaveChanges();
        }
    }
}
