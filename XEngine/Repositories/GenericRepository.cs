using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XEngine.DAL
{
    public class GenericRepository<TEntity> :
        IGenericRepository<TEntity> where TEntity : class
    {
        internal XEngineContext context;
        internal DbSet<TEntity> dbSet;
        public GenericRepository(XEngineContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        public void Delete(object id)
        {
            TEntity entity = dbSet.Find(id);
            dbSet.Remove(entity);
        }
        public virtual void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }
        private bool disposied = false;
        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(disposied);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposied)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposied = true;
        }

        public IEnumerable<TEntity> Get()
        {
            return dbSet.ToList();
        }

        public TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}