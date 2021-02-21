using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        List<TEntity> GetList(Expression<Func<TEntity,bool>>expression=null);
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
