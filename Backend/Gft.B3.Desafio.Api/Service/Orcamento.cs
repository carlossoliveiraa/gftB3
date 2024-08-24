using System;

namespace Gft.B3.Desafio.Api.Service
{
    //Single Responsibility Principle (SRP)
    public class Orcamento
    {
        public double ValorInicial { get; private set; }
        public int PrazoMeses { get; private set; }

        public Orcamento(double valorInicial, int prazoMeses)
        {
            if (valorInicial <= 0)
            {
                throw new ArgumentException("Valor inicial deve ser positivo.");
            }

            if (prazoMeses <= 1)
            {
                throw new ArgumentException("Prazo deve ser maior que 1 mês.");
            }

            ValorInicial = valorInicial;
            PrazoMeses = prazoMeses;
        }

        public bool EhValido(out string mensagemErro)
        {
            if (ValorInicial <= 0)
            {
                mensagemErro = "Erro: Valor inicial deve ser positivo.";
                return false;
            }

            if (PrazoMeses <= 1)
            {
                mensagemErro = "Erro: Prazo deve ser maior que 1 mês.";
                return false;
            }

            mensagemErro = string.Empty;
            return true;
        }
    }
}