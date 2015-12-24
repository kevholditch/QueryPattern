using System.Data;
using System.Linq;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using QueryPatternExample.Queries;

namespace QueryPatternExample
{
    public static class ContainerBuilder
    {
        public static IWindsorContainer Build()
        {
            var container = new WindsorContainer();

            container.AddFacility<TypedFactoryFacility>();            
            container.Register(Component.For<IQueryFactory>().AsFactory());
            
            container.Register(Classes.FromThisAssembly()
                .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IQuery<,>)))
                .WithServiceAllInterfaces());

            container.Register(Component.For<IDbConnection>().UsingFactoryMethod((k, c) => k.Resolve<IConnectionFactory>().GetConnection()));

            container.Register(Classes.FromThisAssembly()
                .IncludeNonPublicTypes()
                .Pick()
                .WithService.AllInterfaces()
                .LifestyleTransient());

            return container;
        }
    }
}
