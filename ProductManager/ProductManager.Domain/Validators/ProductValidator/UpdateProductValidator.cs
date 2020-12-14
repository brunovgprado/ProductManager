using FluentValidation;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager.Domain.Validators.ProductValidator
{
    public class UpdateProductValidator : AbstractValidator<Produto>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage(Resources.ID_PRODUTO_OBRIGATORIO)
                .Must(x => x != Guid.Empty);

            RuleFor(x => x.Nome)
                .NotNull().WithMessage(Resources.NOME_PRODUTO_OBRIGATORIO);

            RuleFor(x => x.Nome)
                .MinimumLength(2).WithMessage(Resources.NOME_PRODUTO_TAMANHO_MINIMO);
        }
    }
}
