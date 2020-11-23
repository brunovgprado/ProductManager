using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManager.Domain.Contracts.Repository
{
    public interface IRepositoryBase<TKey, T>
    {
        Task<TKey> CreateAsync(T entity);
        Task<T> ReadAsync(TKey id);
        Task<IEnumerable<T>> ReadAllAsync(int offset, int limit);
        Task DeleteAsync(TKey id);
    }
}
