using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financeira.Domain.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        void Commit();
    }
}
