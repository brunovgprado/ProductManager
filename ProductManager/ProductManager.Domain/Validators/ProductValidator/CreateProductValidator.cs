using FluentValidation;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Properties;

namespace ProductManager.Domain.Validators.ProductValidator
{
    public class CreateProductValidator : AbstractValidator<Produto>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Nome)
                .NotNull().WithMessage(Resources.NOME_PRODUTO_OBRIGATORIO);

            RuleFor(x => x.Nome)
              .Empty().WithMessage(Resources.NOME_PRODUTO_OBRIGATORIO);

            RuleFor(x => x.Nome)
                .MinimumLength(2).WithMessage(Resources.NOME_PRODUTO_TAMANHO_MINIMO);   
        }
    }
}
