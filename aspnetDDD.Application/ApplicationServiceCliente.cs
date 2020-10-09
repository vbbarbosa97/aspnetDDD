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

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            this.serviceCliente = serviceCliente;
            this.mapperCliente = mapperCliente;
        }
        public void Add(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            var clientesDto = mapperCliente.MapperListClientesDto(clientes);
            return clientesDto;
        }

        public ClienteDto GetById(Guid Id)
        {
            var cliente = serviceCliente.GetByID(Id);
            var clienteDto = mapperCliente.MapperEntityToDto(cliente);
            return clienteDto;
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Update(cliente);
        }
    }
}