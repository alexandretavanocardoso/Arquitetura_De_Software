using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.OCP.OCP.Violacao
{
    // Não esta fechada para modificacao
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoContaEnum tipoConta)
        {
            if(tipoConta == TipoContaEnum.Corrente)
            {
                // Debito Conta Corrente
            }

            if(tipoConta == TipoContaEnum.Poupanca)
            {
                // Valida Aniversario da conta
                // Debita conta Poupanca
            }
        }

    }
}
