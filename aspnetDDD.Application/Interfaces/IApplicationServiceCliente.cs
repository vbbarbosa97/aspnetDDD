using System;
using System.Collections.Generic;
using aspnetDDD.Application.Dtos;

namespace aspnetDDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto clienteDto);
        void Update(ClienteDto clienteDto);
        void Remove(ClienteDto clienteDto);
        IEnumerable<ClienteDto> GetAll();
        ClienteDto GetById(Guid Id);
    }
}