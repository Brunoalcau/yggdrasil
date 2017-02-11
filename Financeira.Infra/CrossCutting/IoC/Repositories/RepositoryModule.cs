using Autofac;
using Financeira.Infra.Context;
using Financeira.Infra.Repositories;
using Financeira.Domain.Interfaces.Repositories;

namespace Financeira.Infra.CrossCutting.IoC.Repositories
{
    public class RepositoryModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DatabaseContext>().AsSelf();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(BusinessRepository)).As(typeof(IBusinessRepository)).InstancePerLifetimeScope();
        }
    }
}
