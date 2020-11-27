using ProductManager.Domain.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ProductManager.Infrastructure.Persistence.Repositories
{
    public class RepositoryBase<Tkey, T> : IRepositoryBase<Tkey, T>
        where T : class
    {
        protected readonly DataContext _context;

        public RepositoryBase(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task CreateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"A entidade {nameof(CreateAsync)} entidade não pode ser nula");
            }

            try
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"A entidade {nameof(entity)} não pôde ser salva: {ex.Message}");
            }
        }

        public Task<IEnumerable<T>> ReadAllAsync(int offset, int limit)
        {
            throw new NotImplementedException();
        }

        public async Task<T> ReadAsync(Tkey id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch(Exception ex)
            {
                throw new Exception($"Não foi possível obter a entidade: {ex.Message}");
            }
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"A entidade {nameof(UpdateAsync)} não pode ser nula");
            }

            try
            {
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"A entidade {nameof(entity)} não pôde ser atualizada: {ex.Message}");
            }
        }

        public async Task DeleteAsync(Tkey id)
        {
            try
            {
                var entity = _context.Set<T>().Find(id);
                await Task.Run(() => _context.Set<T>().Remove(entity));
            }
            catch(Exception ex)
            {
                throw new Exception($"A entidade não pôde ser excluida: {ex.Message}");
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
