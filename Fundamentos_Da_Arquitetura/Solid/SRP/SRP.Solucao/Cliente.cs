using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.SRP.SRP.Solucao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return true;
        }
    }
}
