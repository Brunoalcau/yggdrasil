using Autofac;
using Financeira.Domain.Interfaces.Services;
using Financeira.Application.Services;
using Financeira.Domain.Interfaces;

namespace Financeira.Infra.CrossCutting.IoC.Application
{
    public class ApplicationModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
             builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork))
            .ExternallyOwned()
            .InstancePerLifetimeScope();
            
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            
            builder.RegisterType(typeof(BusinessService)).As(typeof(IBusinessService)).InstancePerLifetimeScope();
        }
    }
}
