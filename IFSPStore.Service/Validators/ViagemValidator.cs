﻿using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class ViagemValidator : AbstractValidator<Viagem>
    {
        public ViagemValidator()
        {
            RuleFor(c => c.DataSaida)
                .NotEmpty().WithMessage("Por favor informe a data de saída.")
                .NotNull().WithMessage("Por favor informe a data de saída.");

            RuleFor(c => c.DataChegada)
                .NotEmpty().WithMessage("Por favor informe a data de chegada.")
                .NotNull().WithMessage("Por favor informe a data de chegada.");
        }
    }
}
