namespace ProductManager.Api.Models.Request
{
    public class CreateProdutoRequest
    {
        public string Nome { get; set; }
        public decimal ValorVenda { get; set; }
        public string imagemUri { get; set; }
    }
}
