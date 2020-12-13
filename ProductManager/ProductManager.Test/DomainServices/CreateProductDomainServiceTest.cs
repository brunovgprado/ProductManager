using AutoMapper;
using FluentAssertions;
using FluentValidation;
using Moq;
using ProductManager.Application.AppServices;
using ProductManager.Application.Contracts;
using ProductManager.Application.Helpers;
using ProductManager.Application.Models.DTO;
using ProductManager.Domain.Contracts.DomainServices;
using ProductManager.Domain.Contracts.Repository;
using ProductManager.Domain.DomainServices;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Validators.ProductValidator;
using ProductManager.Test.Builders;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ProductManager.Test.DomainServices
{
    public class CreateProductDomainServiceTest
    {
        private readonly CreateProductValidator _createprodutoValidator;
        private readonly UpdateProductValidator _updateprodutoValidator;
        private readonly Mock<IProdutoRepository> _produtoRepositoryMock;
        private readonly IProdutoDomainService _produtoDomainService;
        private readonly IMapper _mapper;

        public CreateProductDomainServiceTest()
        {
            _createprodutoValidator = new CreateProductValidator();
            _updateprodutoValidator = new UpdateProductValidator();
            _produtoRepositoryMock = new Mock<IProdutoRepository>();
            _produtoDomainService = new ProdutoDomainService(
                _produtoRepositoryMock.Object, 
                _createprodutoValidator, 
                _updateprodutoValidator);

            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new AutoMapperProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [Fact]
        public async Task CreateProduto_Success()
        {
            //Arrange
            var entity = new ProductBuilder().Build();

            //Act
            var response = await _produtoDomainService.CreateAsync(entity);

            //Assert
            response.Should().NotBeEmpty();
        }

        [Fact]
        public async Task Create_WithNameEmptyShouldThrowValidationException()
        {
            //Arrange
            var entity = new ProductBuilder().WithNomeEmpty();

            //Act/Assert
            await Assert.ThrowsAsync<ValidationException>(
                async () => await _produtoDomainService.CreateAsync(entity));
        }

    }
}
