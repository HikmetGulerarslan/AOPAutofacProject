using AOP.Business.Abstract;
using AOP.Business.Concrete;
using AOPExample.CrossCuttingConcers.Caching;
using AOPExample.CrossCuttingConcers.Caching.Microsoft;
using AOPExample.Utilities.Interceptors;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;

namespace AOP.Business.AutofacContainer
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MemoryCacheService>().As<ICacheService>();
            builder.RegisterType<Example>().As<IExample>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterseptorSelector()
                }).InstancePerLifetimeScope();
        }
    }
}
