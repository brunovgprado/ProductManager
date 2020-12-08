using Bogus;
using ProductManager.Domain.Entities;
using ProductManager.Test.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager.Test.Builders
{
    public class ProductBuilder
    {
        private readonly Faker _faker;
        private readonly Produto _instance;

        public ProductBuilder()
        {
            _faker = FakerPtbr.CreateFaker();
            _instance = new Produto
            {
                Id = _faker.Random.Guid(),
                Nome = _faker.Random.String(),
                Valor = _faker.Random.Decimal()
            };
        }

        public Produto WithIdEmpty()
        {
            _instance.Id = Guid.Empty;
            return _instance;
        }

        public Produto WithNomeEmpty()
        {
            _instance.Nome = "";
            return _instance;
        }

        public Produto Build()
        {
            return _instance;
        }
    }
}
