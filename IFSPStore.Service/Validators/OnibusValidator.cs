using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class OnibusValidator : AbstractValidator<Onibus>
    {
        public OnibusValidator()
        {
            RuleFor(c => c.Placa)
                .NotEmpty().WithMessage("Por favor informe a placa.")
                .NotNull().WithMessage("Por favor informe a placa.")
                .MaximumLength(12).WithMessage("Placa pode ser de no máximo 12 caracteres.");

            RuleFor(c => c.Modelo)
                .NotEmpty().WithMessage("Por favor informe o modelo.")
                .NotNull().WithMessage("Por favor informe o modelo.")
                .MaximumLength(45).WithMessage("Modelo pode ser de no máximo 45 caracteres.");
        }
    }

    public class AssentoValidator : AbstractValidator<Assento>
    {
        public AssentoValidator()
        {
            RuleFor(c => c.NumeroAssento)
                .NotEmpty().WithMessage("Por favor informe o número do assento.")
                .NotNull().WithMessage("Por favor informe o número do assento.");
        }
    }
}
