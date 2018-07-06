using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace XEngine.DAL
{
    public interface IGenericRepository<TEntity>
        : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> Get();
        TEntity GetByID(object id);

        void Insert(TEntity entity);
        void Delete(object id);
        void Update(TEntity entity);

        void Save();
    }
}