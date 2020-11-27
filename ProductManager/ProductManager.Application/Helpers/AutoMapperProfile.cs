using AutoMapper;
using ProductManager.Application.Models.DTO;
using ProductManager.Domain.Entities;

namespace ProductManager.Application.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProdutoDto, Produto>();
            CreateMap<Produto, ProdutoDto>();
        }
    }
}
