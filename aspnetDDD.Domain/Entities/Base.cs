using System;

namespace aspnetDDD.Domain.Entities
{
    public class Base
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}