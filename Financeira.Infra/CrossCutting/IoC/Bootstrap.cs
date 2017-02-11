using System;
using System.Reflection;
using Autofac;
using Financeira.Infra.CrossCutting.IoC.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Autofac.Extensions.DependencyInjection;
using Financeira.Infra.CrossCutting.IoC.Application;

namespace Financeira.Infra.CrossCutting.IoC
{
    
    public class Bootstrap
    {
        private readonly ContainerBuilder builder;
        public Bootstrap(){
            builder = new ContainerBuilder();
        }

        public IServiceProvider Config(IServiceCollection services)
        {
            AddResgisters();
            
            builder.Populate(services);
            
            var container = builder.Build();
            
            return container.Resolve<IServiceProvider>();
        }

        public void AddResgisters()
        {
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ApplicationModule());
        }
    }
}
