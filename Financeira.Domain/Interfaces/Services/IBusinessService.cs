using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeira.Domain.Entities;

namespace Financeira.Domain.Interfaces.Services
{
    public interface IBusinessService: IService<Business>
    {
        IEnumerable<Business>GetAllByPeriod(DateTime? start, DateTime? end, bool isGroupByCategory);

        IEnumerable<Business>GetAll(bool isGroupByCategory);
    }
}
