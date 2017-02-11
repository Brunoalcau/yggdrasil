using System;
using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
using Financeira.Domain.Entities;
using Financeira.Domain.Interfaces.Repositories;
using Financeira.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Financeira.Infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        
        protected  DatabaseContext _databaseContext;
        protected  DbSet<TEntity> _dbSet;
        public Repository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _dbSet = _databaseContext.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            try
            {
                _dbSet.Add(entity);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                _dbSet.Remove(entity);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public virtual void DeleteAll(IList<TEntity> entities)
        {
            try
            {
                _dbSet.RemoveRange(entities);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public virtual void Edit(TEntity entity)
        {
            try
            {
                _dbSet.Update(entity);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public virtual TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsEnumerable();
        }
    }
}
