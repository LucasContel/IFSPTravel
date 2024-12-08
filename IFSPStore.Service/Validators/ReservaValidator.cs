using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class ReservaValidator : AbstractValidator<Reserva>
    {
        public ReservaValidator()
        {
            RuleFor(c => c.Assento)
                .NotNull().WithMessage("Por favor selecione um assento válido!");
        }
    }
}
