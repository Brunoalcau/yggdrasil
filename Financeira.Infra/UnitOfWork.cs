using System;
using Financeira.Domain.Interfaces;
using Financeira.Infra.Context;

namespace Financeira.Infra
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;
		private bool _disposed = false;
        public UnitOfWork(DatabaseContext databaseContext)
		{            
			_databaseContext = databaseContext;
		}

        public void Commit()
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(this.GetType().FullName);
			}
			
			_databaseContext.SaveChanges();            
		}


        public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
        protected virtual void Dispose(bool disposing)
		{
			if (_disposed) return;
			if (disposing && _databaseContext != null)
			{
				_databaseContext.Dispose();
			}
			_disposed = true;
		}
    }
}
