using Autofac;

namespace KingCraft.Persistence
{
    public class PersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(PersistenceModule).Assembly)
                .AsImplementedInterfaces();

            base.Load(builder);
        }
    }
}
