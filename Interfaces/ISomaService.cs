using SumApi.Dtos;
using SumApi.Models;

namespace SumApi.Interfaces
{
    public interface ISomaService
    {
        SomaDto Somar(SomaRequest request);
    }
}
