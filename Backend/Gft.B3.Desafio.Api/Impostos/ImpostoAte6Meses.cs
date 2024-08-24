using Gft.B3.Desafio.Api.Interface;

namespace Gft.B3.Desafio.Api.Impostos
{
    public class ImpostoAte6Meses : ICalculoImposto
    {
        public double CalcularImposto(double lucro, int prazoMeses) => lucro * 0.225;
    }
}