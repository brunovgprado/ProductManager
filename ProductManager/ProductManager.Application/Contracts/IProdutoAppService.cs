using ProductManager.Application.Models.DTO;
using System;
using System.Threading.Tasks;

namespace ProductManager.Application.Contracts
{
    public interface IProdutoAppService
    {
        Task<Object> CreateAsync(ProdutoDto produtoDto);
    }
}
