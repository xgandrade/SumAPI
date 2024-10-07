using FluentValidation.AspNetCore;
using FluentValidation;
using System.Reflection;

namespace SumApi.Extensions
{
    public static class ValidatorExtensions
    {
        public static void AddValidators(this IServiceCollection services, Assembly assembly)
        {
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssembly(assembly);
        }
    }
}
