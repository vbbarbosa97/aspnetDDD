using System.Collections.Generic;
using aspnetDDD.Application.Dtos;
using aspnetDDD.Domain.Entities;

namespace aspnetDDD.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}