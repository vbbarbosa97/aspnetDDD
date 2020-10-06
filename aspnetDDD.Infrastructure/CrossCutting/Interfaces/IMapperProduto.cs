using System.Collections.Generic;
using aspnetDDD.Application.Dtos;
using aspnetDDD.Domain.Entities;

namespace aspnetDDD.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}