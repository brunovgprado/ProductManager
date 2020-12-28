using ProductManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManager.Domain.Contracts.DomainServices
{
    public interface IProdutoDomainService
    {
        Task<Guid> CreateAsync(Produto produto);
        Task<Produto> ReadAsync(Guid id);
        Task<IEnumerable<Produto>> ReadAllAsync(int offset, int limit);
        Task UpdateAsync(Produto produto);
        Task DeleteAsync(Guid id);
    }
}
