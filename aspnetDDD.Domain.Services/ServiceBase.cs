using System;
using System.Collections.Generic;
using aspnetDDD.Domain.Core.Interfaces.Repositorys;
using aspnetDDD.Domain.Core.Interfaces.Services;

namespace aspnetDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repositoryBase;
        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }
        public void Add(TEntity obj)
        {
            repositoryBase.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repositoryBase.GetAll();
        }

        public TEntity GetByID(Guid id)
        {
            return repositoryBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            repositoryBase.Delete(obj);
        }

        public void Update(TEntity obj)
        {
            repositoryBase.Update(obj);
        }
    }
}