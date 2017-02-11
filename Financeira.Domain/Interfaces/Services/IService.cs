using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeira.Domain.Entities;
namespace Financeira.Domain.Interfaces.Services
{
    public interface IService<TEntity> where TEntity: EntityBase
    {
        void Add(TEntity entity);
        
        void Delete(TEntity entity);

        void DeleteAll(IList<TEntity> entities);

        void Edit(TEntity entity);

        TEntity Get(int id);

        IEnumerable<TEntity> GetAll();
    }
}
