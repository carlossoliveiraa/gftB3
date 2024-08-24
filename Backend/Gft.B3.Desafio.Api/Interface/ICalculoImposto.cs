using Gft.B3.Desafio.Api.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gft.B3.Desafio.Api.Interface
{
    public interface ICalculoImposto
    {
        double CalcularImposto(double lucro, int prazoMeses);
    }
}
