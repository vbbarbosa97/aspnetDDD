using System;
using System.Collections.Generic;
using aspnetDDD.Application.Dtos;
using aspnetDDD.Application.Interfaces;
using aspnetDDD.Application.Interfaces.Mappers;
using aspnetDDD.Domain.Core.Interfaces.Services;

namespace aspnetDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;

        public void Add(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteDto GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public void Update(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }
    }
}