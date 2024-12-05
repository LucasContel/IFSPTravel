using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class PassageiroValidator : AbstractValidator<Passageiro>
    {
        public PassageiroValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.")
                .MaximumLength(100).WithMessage("Nome pode ser de no máximo 100 caracteres.");

            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("Por favor informe o telefone.")
                .NotNull().WithMessage("Por favor informe o telefone.")
                .MaximumLength(30).WithMessage("Telefone pode ser de no máximo 30 caracteres.");

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("Por favor informe o CPF.")
                .NotNull().WithMessage("Por favor informe o CPF.")
                .MaximumLength(16).WithMessage("CPF pode ser de no máximo 16 caracteres.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email.")
                .EmailAddress().WithMessage("E-mail inválido.");
        }
    }
}
