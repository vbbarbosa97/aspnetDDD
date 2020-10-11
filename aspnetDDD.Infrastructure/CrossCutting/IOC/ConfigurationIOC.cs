using aspnetDDD.Application;
using aspnetDDD.Application.Interfaces;
using aspnetDDD.Application.Interfaces.Mappers;
using aspnetDDD.Application.Mappers;
using aspnetDDD.Domain.Core.Interfaces.Repositorys;
using aspnetDDD.Domain.Core.Interfaces.Services;
using aspnetDDD.Domain.Services;
using aspnetDDD.Infrastructure.Data.Repositorys;
using Autofac;

namespace aspnetDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();

            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();

            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion
        }
    }
}