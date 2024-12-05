using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class CidadeValidator : AbstractValidator<Cidade>
    {
        public CidadeValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.")
                .MaximumLength(100).WithMessage("Nome pode ser de no máximo 100 caracteres.");

            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("Por favor informe o estado.")
                .NotNull().WithMessage("Por favor informe o estado.")
                .MaximumLength(4).WithMessage("Estado pode ser de no máximo 3 caracteres.");
        }

    }
}
