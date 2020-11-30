using AutoMapper;
using FluentValidation;
using ProductManager.Application.Contracts;
using ProductManager.Application.Models.DTO;
using ProductManager.Application.Properties;
using ProductManager.Application.Shared;
using ProductManager.Domain.Contracts.DomainServices;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Exceptions;
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

        public async Task<Response<Object>> CreateAsync(ProdutoDto produtoDto)
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
            catch (Exception ex)
            {
                return response.SetInternalServerError($"{Resources.UnexpectedErrorCreatingProduto} : {ex.Message}");
            }
        }

        public async Task<Response<Produto>> ReadAsync(Guid id)
        {
            var response = new Response<Produto>();

            try
            {
                return response.SetResult( await _produtoDomainService.ReadAsync(id));
            }
            catch(EntityNotExistsException)
            {
                return response.SetNotFound(Resources.ProdutoNotFound);
            }
            catch(Exception ex)
            {
                return response.SetInternalServerError($"{Resources.UnexpectedErrorCreatingProduto} : {ex.Message}");
            }
        }
    }
}
