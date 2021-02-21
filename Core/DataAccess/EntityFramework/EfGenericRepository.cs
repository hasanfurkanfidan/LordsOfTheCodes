using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfGenericRepository<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using var context = new TContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            context.Remove(entity);
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            using var context = new TContext();
            return context.Set<TEntity>().Where(expression).FirstOrDefault();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context = new TContext())
            {
                if (expression!=null)
                {
                    return context.Set<TEntity>().Where(expression).ToList();
                }
                return context.Set<TEntity>().ToList();

            }
        }

        public void Update(TEntity entity)
        {
            using var context = new TContext();
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
