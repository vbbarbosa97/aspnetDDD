using System;

namespace aspnetDDD.Application.Dtos
{
    public class ProdutoDto
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}