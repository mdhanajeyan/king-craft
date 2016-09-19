using Autofac;
using KingCraft.Contracts.Persistence.Repositories;
using KingCraft.Persistence.Repositories;

namespace KingCraft.Persistence
{
    public class PersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(PersistenceModule).Assembly)
                .AsImplementedInterfaces();

            builder.RegisterGeneric(typeof(Repository<>))
                .As(typeof(IRepository<>));

            builder.RegisterType<KingCraftContext>()
                .AsSelf()
                .InstancePerRequest();

            base.Load(builder);
        }
    }
}
