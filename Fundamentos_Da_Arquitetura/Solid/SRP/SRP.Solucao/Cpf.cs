using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.SRP.SRP.Solucao
{
    public class Cpf
    {
        public string Numero { get; set; }

        public bool Validar()
        {
            return Numero.Length == 11;
        }
    }
}
