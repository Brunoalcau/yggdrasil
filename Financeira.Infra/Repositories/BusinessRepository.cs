using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeira.Domain.Entities;
using Financeira.Domain.Interfaces.Repositories;
using Financeira.Infra.Context;

namespace Financeira.Infra.Repositories
{
    public class BusinessRepository : Repository<Business>, IBusinessRepository
    {
        public BusinessRepository(DatabaseContext databaseContext) 
        : base(databaseContext)
        {
        }

        public IEnumerable<Business> GetAllGroupByCategory()
        {
            return _dbSet.GroupBy(b=>b.Category).Select(x=> new Business(){
                    Value = x.Sum(y=> y.Value),
                    Category = x.First().Category,
                    Type = x.First().Type,
                    Date = x.First().Date,
                    Observation = x.First().Observation
                });
        }
    }
}
