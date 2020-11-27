using ProductManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Domain.Contracts.DomainServices
{
    public interface IProdutoDomainService
    {
        Task<Guid> CreateAsync(Produto produto);
        Task<Produto> ReadAsync(Guid id);
        Task<IEnumerable<Produto>> ReadAllAsync(int offset, int limit);
        Task DeleteAsync(Guid id);
    }
}
