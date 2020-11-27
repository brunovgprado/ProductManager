using System;

namespace ProductManager.Application.Models.DTO
{
    public class ProdutoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string imagemUri { get; set; }
    }
}
