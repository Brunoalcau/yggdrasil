using Financeira.Domain.Interfaces.Services;
using Financeira.Domain.Entities;
using System;
using System.Collections.Generic;
using Financeira.Domain.Interfaces.Repositories;
using Financeira.Domain.Interfaces;


namespace Financeira.Application.Services
{
    public class Service<TEntity>: IService<TEntity> where TEntity: EntityBase
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public Service(IRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public virtual void Add(TEntity entity)
        {
            _repository.Add(entity);
            _unitOfWork.Commit();
        }

        public virtual void Delete(TEntity entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public virtual void DeleteAll(IList<TEntity> entities)
        {
            _repository.DeleteAll(entities);
            _unitOfWork.Commit();
        }

        public virtual void Edit(TEntity entity)
        {
            _repository.Edit(entity);
            _unitOfWork.Commit();
        }

        public virtual TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
