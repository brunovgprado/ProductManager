using System;

namespace ProductManager.Api.Models.Request
{
    public class UpdateProdutoRequest
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorVenda { get; set; }
        public string imagemUri { get; set; }
    }
}
