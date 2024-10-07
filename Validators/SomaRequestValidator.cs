using FluentValidation;
using SumApi.Models;

namespace SumApi.Validators
{
    public class SomaRequestValidator : AbstractValidator<SomaRequest>
    {
        public SomaRequestValidator()
        {
            RuleFor(x => x.Valor1).NotNull().GreaterThan(0);
            RuleFor(x => x.Valor2).NotNull().GreaterThan(0);
        }
    }
}
