using aspnetDDD.Domain.Core.Interfaces.Repositorys;
using aspnetDDD.Domain.Core.Interfaces.Services;
using aspnetDDD.Domain.Entities;

namespace aspnetDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;
        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}