using Gft.B3.Desafio.Api.Interface;

namespace Gft.B3.Desafio.Api.Impostos
{
    public class ImpostoAcima24Meses : ICalculoImposto
    {
        public double CalcularImposto(double lucro, int prazoMeses) => lucro * 0.15;
    }
}