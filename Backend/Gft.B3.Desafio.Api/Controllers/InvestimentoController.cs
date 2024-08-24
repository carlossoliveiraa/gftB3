using Gft.B3.Desafio.Api.Interface;
using Gft.B3.Desafio.Api.Service;
using System;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Gft.B3.Desafio.Api.Controllers
{
    public class InvestimentoController : ApiController
    {
      
        [HttpPost]
        [Route("api/CDB/calcular")]
        public IHttpActionResult CalcularInvestimento([FromBody] Orcamento orcamento)
        {
            if (orcamento == null || orcamento.ValorInicial <= 0 || orcamento.PrazoMeses <= 1)
            {
                return BadRequest("Erro: Valor inicial deve ser positivo e prazo deve ser maior que 1 mês.");
            }
                      
            ICalculoInvestimento calculoCDB = new CalculoCDB();
            double valorFinal = calculoCDB.CalcularValorFinal(orcamento);
            double imposto = calculoCDB.CalcularImposto(valorFinal, orcamento);
            double valorLiquido = Math.Round((valorFinal - imposto),2);
                     
            var resultado = new
            {
                ValorFinalBruto = valorFinal,
                Imposto = imposto,
                ValorFinalLiquido = valorLiquido
            };

            return Ok(resultado);
        }
    }
}
