using Autofac;
using KingCraft.Core;
using KingCraft.Persistence;

namespace KingCraft.IOC
{
    public class IocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new PersistenceModule());
            builder.RegisterModule(new CoreModule());

            base.Load(builder);
        }
    }
}