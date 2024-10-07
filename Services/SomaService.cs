using SumApi.Dtos;
using SumApi.Interfaces;
using SumApi.Models;

namespace SumApi.Services
{
    public class SomaService : ISomaService
    {
        public SomaDto Somar(SomaRequest request) => new() { Resultado = request.Valor1 + request.Valor2 };
    }
}
