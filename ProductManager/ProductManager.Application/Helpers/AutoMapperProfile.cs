using AutoMapper;
using ProductManager.Application.Models.DTO;

namespace ProductManager.Application.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProdutoDto, Produto>();
        }
    }
}
