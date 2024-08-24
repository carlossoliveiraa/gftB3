using Gft.B3.Desafio.Api.Service;

namespace Gft.B3.Desafio.Api.Interface
{
    public interface ICalculoInvestimento
    {
        double CalcularValorFinal(Orcamento orcamento);
        double CalcularImposto(double valorFinal, Orcamento orcamento);
    }
}
