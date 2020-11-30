using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Api.Contracts;
using ProductManager.Api.Models;
using ProductManager.Api.Models.Request;
using ProductManager.Application.Contracts;
using ProductManager.Application.Models.DTO;
using System;
using System.Threading.Tasks;

namespace ProductManager.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IActionResultConverter _actionResultConverter;
        private readonly IProdutoAppService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoController(
            IActionResultConverter actionResultConverter,
            IProdutoAppService produtoService,
            IMapper mapper)
        {
            _actionResultConverter = actionResultConverter;
            _produtoService = produtoService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProdutoRequest produto)
        {
            var produtoDto = _mapper.Map<ProdutoDto>(produto);
            return _actionResultConverter.Convert(await _produtoService.CreateAsync(produtoDto));
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]Guid id)
        {
            return _actionResultConverter.Convert(await _produtoService.ReadAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProdutoRequest produto)
        {
            var produtoDto = _mapper.Map<ProdutoDto>(produto);
            return _actionResultConverter.Convert(await _produtoService.CreateAsync(produtoDto));
        }
    }
}
