using aspnetDDD.Domain.Core.Interfaces.Repositorys;
using aspnetDDD.Domain.Core.Interfaces.Services;
using aspnetDDD.Domain.Entities;

namespace aspnetDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;
        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}