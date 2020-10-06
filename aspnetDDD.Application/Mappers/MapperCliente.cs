using System.Collections.Generic;
using System.Linq;
using aspnetDDD.Application.Dtos;
using aspnetDDD.Application.Interfaces.Mappers;
using aspnetDDD.Domain.Entities;

namespace aspnetDDD.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Email = clienteDto.Email,
                Sobrenome = clienteDto.Sobrenome,
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Email = cliente.Email,
                Sobrenome = cliente.Sobrenome,
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c => new ClienteDto
            {
                Id = c.Id,
                Nome = c.Nome,
                Sobrenome = c.Sobrenome,
                Email = c.Email,
            });

            return dto;
        }
    }
}