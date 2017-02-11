using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeira.Domain.Entities;

namespace Financeira.Domain.Interfaces.Repositories
{
    public interface IBusinessRepository: IRepository<Business>
    {
        IEnumerable<Business>  GetAllGroupByCategory();
    }
}
