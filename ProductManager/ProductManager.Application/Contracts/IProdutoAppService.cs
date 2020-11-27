using ProductManager.Application.Models.DTO;
using ProductManager.Application.Shared;
using System;
using System.Threading.Tasks;

namespace ProductManager.Application.Contracts
{
    public interface IProdutoAppService
    {
        Task<Response<Object>> CreateAsync(ProdutoDto produtoDto);
    }
}
