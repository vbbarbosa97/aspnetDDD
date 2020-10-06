using System;
using System.Collections.Generic;
using System.Linq;
using aspnetDDD.Domain.Core.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;

namespace aspnetDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;
        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }
        public void Add(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(obj);
                sqlContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Remove(obj);
                sqlContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                var entitys = sqlContext.Set<TEntity>().ToList();
                return entitys;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public TEntity GetById(Guid Id)
        {
            try
            {
                var entity = sqlContext.Set<TEntity>().Find(Id);
                return entity;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public void Update(TEntity obj)
        {
            try
            {
                sqlContext.Entry(obj).State = EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}