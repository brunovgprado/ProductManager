using ProductManager.Domain.Entities;
using System;

namespace ProductManager.Domain.Contracts.Repository
{
    public interface IProdutoRepository : IRepositoryBase<Guid, Produto>
    {
    }
}
