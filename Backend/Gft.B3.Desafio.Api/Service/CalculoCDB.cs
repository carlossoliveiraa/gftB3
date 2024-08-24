using Gft.B3.Desafio.Api.Impostos;
using Gft.B3.Desafio.Api.Interface;
using System;
using System.Collections.Generic;

namespace Gft.B3.Desafio.Api.Service
{
    public class CalculoCDB : ICalculoInvestimento
    {
        private const double CDI = 0.009; // 0.9% ao mês
        private const double TB = 1.08;   // 108% do CDI

        private readonly Dictionary<string, double> cacheValorFinal = new Dictionary<string, double>();
        private readonly Dictionary<string, double> cacheImposto = new Dictionary<string, double>();

        public double CalcularValorFinal(Orcamento orcamento)
        {
            string cacheKey = $"{orcamento.ValorInicial}-{orcamento.PrazoMeses}";

            if (cacheValorFinal.TryGetValue(cacheKey, out double valorFinal))
            {
                return valorFinal;
            }
                       
            Func<double, int, double> calcular = (valorInicial, prazoMeses) =>
            {
                return Math.Round(valorInicial * Math.Pow(1 + (CDI * TB), prazoMeses), 2);
            };

            valorFinal = calcular(orcamento.ValorInicial, orcamento.PrazoMeses);

            cacheValorFinal[cacheKey] = valorFinal;

            return valorFinal;
        }
 
        public double CalcularImposto(double valorFinal, Orcamento orcamento)
        {
            string cacheKey = $"{valorFinal}-{orcamento.PrazoMeses}";

            if (cacheImposto.TryGetValue(cacheKey, out double imposto))
            {
                return imposto;
            }

            double lucro = valorFinal - orcamento.ValorInicial;
            ICalculoImposto calculoImposto = ObterCalculoImposto(orcamento.PrazoMeses);
            imposto = Math.Round(calculoImposto.CalcularImposto(lucro, orcamento.PrazoMeses), 2);

            cacheImposto[cacheKey] = imposto;

            return imposto;
        }

        private static readonly Dictionary<Func<int, bool>, Func<ICalculoImposto>> calculoImpostoMap =
      new Dictionary<Func<int, bool>, Func<ICalculoImposto>>
      {
        { prazo => prazo <= 6, () => new ImpostoAte6Meses() },
        { prazo => prazo <= 12, () => new ImpostoAte12Meses() },
        { prazo => prazo <= 24, () => new ImpostoAte24Meses() },
        { prazo => prazo > 24, () => new ImpostoAcima24Meses() }
      };

        private ICalculoImposto ObterCalculoImposto(int prazoMeses)
        {
            foreach (var entry in calculoImpostoMap)
            {
                if (entry.Key(prazoMeses))
                {
                    return entry.Value();
                }
            }

            throw new InvalidOperationException("Prazo de meses inválido para cálculo de imposto.");
        }

    }
}