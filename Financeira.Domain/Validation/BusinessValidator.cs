using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeira.Domain.Entities;
using FluentValidation;

namespace Financeira.Domain.Validation
{
    public class BusinessValidator: AbstractValidator<Business>
    {
        public BusinessValidator()
        {
            RuleFor(x=>x.Category).NotEmpty().WithMessage("Categoria Obrigatória");
            RuleFor(x=>x.Date).NotEmpty().WithMessage("Data Obrigatória");
            RuleFor(x=>x.Type).NotNull().WithMessage("Tipo Obrigatória");
            RuleFor(x=>x.Value).NotEmpty().WithMessage("Tipo Obrigatória");

        }
    }
}
