using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using KingCraft.IOC;

namespace KingCraft.Web
{
    public class Global : HttpApplication
    {
        private static IContainer Container { get; set; }
        void Application_Start(object sender, EventArgs e)
        {
            var container = SetupDependencyInjection();
            var config = GlobalConfiguration.Configuration;

            //MVC
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            AreaRegistration.RegisterAllAreas();

            //Api
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Route Registration
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private IContainer SetupDependencyInjection()
        {
            var builder = new ContainerBuilder();

            //Register our mvc controller 
            builder.RegisterControllers(typeof(Global).Assembly);

            //Register api controllers
            builder.RegisterApiControllers(typeof(Global).Assembly);
            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            //Register module
            builder.RegisterModule(new AutofacWebTypesModule());

            builder.RegisterModule(new IocModule());

            builder.RegisterAssemblyModules(typeof(WebModule).Assembly);

            Container = builder.Build();
            return Container;
        }
    }
}