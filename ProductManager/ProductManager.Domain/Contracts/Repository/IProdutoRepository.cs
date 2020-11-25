using ProductManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager.Domain.Contracts.Repository
{
    public interface IProdutoRepository : IRepositoryBase<Produto, Guid>
    {
    }
}
