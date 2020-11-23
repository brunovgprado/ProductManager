using System;

namespace ProductManager.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string imagemUri { get; set; }
    }
}
