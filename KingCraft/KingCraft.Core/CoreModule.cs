﻿using Autofac;

namespace KingCraft.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(CoreModule).Assembly)
                .AsImplementedInterfaces();

            base.Load(builder);
        }
    }
}
