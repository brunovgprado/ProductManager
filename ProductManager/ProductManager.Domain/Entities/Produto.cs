using System;

namespace ProductManager.Domain.Entities
{
    public class Produto
    {
        private Guid id;

        public Guid GetId()
        {
            return id;
        }

        public void SetId(Guid value)
        {
            id = value;
        }

        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string imagemUri { get; set; }
    }
}
