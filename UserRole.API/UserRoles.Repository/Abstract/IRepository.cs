using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserRoles.Repository.Abstract
{
    public interface IRepository<T>
    {
        IQueryable<T> Table { get; } //Entitylere karşılık gelmektedir.
        IQueryable<T> TableNoTracking { get; }
        T GetById(object id);
        void Insert(T entity);
        void Insert(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        IEnumerable<T> GetSql(string sql);
    }
}
