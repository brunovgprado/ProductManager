using FluentValidation;
using ProductManager.Domain.Contracts.DomainServices;
using ProductManager.Domain.Contracts.Repository;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Exceptions;
using ProductManager.Domain.Validators.ProductValidator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Domain.DomainServices
{
    public class ProdutoDomainService : IProdutoDomainService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly CreateProductValidator _createProductValidator;

        public ProdutoDomainService(
            IProdutoRepository produtoRepository,
            CreateProductValidator createProductValidator)
        {
            _produtoRepository = produtoRepository;
            _createProductValidator = createProductValidator;
        }

        public async Task<Guid> CreateAsync(Produto produto)
        {
            //Validando a entidade
            await _createProductValidator.ValidateAndThrowAsync(produto);

            produto.SetId(Guid.NewGuid());

            await _produtoRepository.CreateAsync(produto);

            return produto.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            var produto = await _produtoRepository.ReadAsync(id);

            if (produto == null)
                throw new EntityNotExistsException();

            await _produtoRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Produto>> ReadAllAsync(int offset, int limit)
        {
            throw new NotImplementedException();
        }

        public async Task<Produto> ReadAsync(Guid id)
        {
            var produto = await _produtoRepository.ReadAsync(id);

            if (produto == null)
                throw new EntityNotExistsException();

            return produto;
        }
    }
}
