using System;
using System.Collections.Generic;
using aspnetDDD.Application.Dtos;

namespace aspnetDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);
        void Update(ProdutoDto produtoDto);
        void Remove(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> GetAll();
        ClienteDto GetById(Guid Id);
    }
}