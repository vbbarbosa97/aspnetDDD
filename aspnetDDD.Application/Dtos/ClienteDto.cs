using System;

namespace aspnetDDD.Application.Dtos
{
    public class ClienteDto
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
    }
}