using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.OCP.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            return FormataTransacao();
        }
    }
}
