using AutoMapper;
using FluentValidation;
using ProductManager.Application.Contracts;
using ProductManager.Application.Models.DTO;
using ProductManager.Application.Properties;
using ProductManager.Application.Shared;
using ProductManager.Domain.Contracts.DomainServices;
using ProductManager.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace ProductManager.Application.AppServices
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoDomainService _produtoDomainService;
        private readonly IMapper _mapper;

        public ProdutoAppService(
            IProdutoDomainService produtoDomainService,
            IMapper mapper)
        {
            _produtoDomainService = produtoDomainService;
            _mapper = mapper;
        }

        public async Task<Object> CreateAsync(ProdutoDto produtoDto)
        {
            var response = new Response<Object>();
            try
            {
                var produtoEntity = _mapper.Map<Produto>(produtoDto);
                var result = await _produtoDomainService.CreateAsync(produtoEntity);
                return response.SetResult(new { Id = result });
            }
            catch (ValidationException ex)
            {
                return response.SetRequestValidationError(ex);
            }
            catch (Exception)
            {
                return response.SetInternalServerError(Resources.UnexpectedErrorCreatingProduto);
            }
        }
    }
}
