using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.SRP.SRP.Solucao
{
    public class Email
    {
        public string Endereco { get; set; }

        public bool Validar()
        {
            return Endereco.Contains("@");
        }
    }
}
