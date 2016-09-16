using Autofac;

namespace KingCraft.Web
{
    public class WebModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(WebModule).Assembly)
                .AsImplementedInterfaces();

            base.Load(builder);
        }
    }
}