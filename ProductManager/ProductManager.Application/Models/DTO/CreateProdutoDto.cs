namespace ProductManager.Application.Models.DTO
{
    public class CreateProdutoDto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string imagemUri { get; set; }
    }
}
