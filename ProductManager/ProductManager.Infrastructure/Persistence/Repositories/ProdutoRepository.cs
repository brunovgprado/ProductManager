using ProductManager.Domain.Contracts.Repository;
using ProductManager.Domain.Entities;
using System;

namespace ProductManager.Infrastructure.Persistence.Repositories
{
    public class ProdutoRepository : RepositoryBase<Guid, Produto>, IProdutoRepository
    {
        protected readonly DataContext _produtoContext;

        public ProdutoRepository(DataContext context)
            :base(context)
        {
            _produtoContext = context;
        }
    }
}
