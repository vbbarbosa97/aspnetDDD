using aspnetDDD.Application;
using aspnetDDD.Application.Interfaces;
using aspnetDDD.Domain.Core.Interfaces.Services;
using Autofac;

namespace aspnetDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Loid(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            // builder.RegisterType<ServiceCliente>().As<IServiceCliente>();

            #endregion
        }
    }
}