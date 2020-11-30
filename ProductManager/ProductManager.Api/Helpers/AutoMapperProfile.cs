using AutoMapper;
using ProductManager.Api.Models.Request;
using ProductManager.Application.Models.DTO;

namespace ProductManager.Api.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateProdutoRequest, ProdutoDto>();
            CreateMap<UpdateProdutoRequest, ProdutoDto>();
        }
    }
}
