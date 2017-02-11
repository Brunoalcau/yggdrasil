using Financeira.Domain.Interfaces.Services;
using Financeira.Domain.Entities;
using Financeira.Domain.Interfaces.Repositories;
using Financeira.Domain.Interfaces;
using System.Linq;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;

namespace Financeira.Application.Services
{
    public class BusinessService : Service<Business>, IBusinessService
    {
        private readonly IBusinessRepository _repository;
        public BusinessService(IBusinessRepository repository, IUnitOfWork unitOfWork) 
        : base(repository, unitOfWork)
        {
            _repository = repository;
        }

        public IEnumerable<Business> GetAllByPeriod(DateTime? start, DateTime? end, bool isGroupByCategory)
        {
            IEnumerable<Business> listGroup = null;
            if(start > end)
            {
                throw new Exception("Valor final menor que valor inicial");
            }
            if(isGroupByCategory)
            {
                listGroup = _repository.GetAllGroupByCategory();
            }else 
            {
                listGroup = _repository.GetAll();
            }
            
            // return this.GetAll(isGroupByCategory).Where(b=> b.Date >= start  &&  b.Date <= end);
            return listGroup.Where(b=> b.Date >= start  &&  b.Date <= end);
            // return _repository.GetAllByPeriod(start, end);
        }

        public IEnumerable<Business> GetAll(bool isGroupByCategory){
            
            if(isGroupByCategory)
            {
               return _repository.GetAllGroupByCategory();
            }
            return _repository.GetAll();
        }
    }
}
