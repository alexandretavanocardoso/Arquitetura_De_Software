using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Solid.SRP.SRP.Solucao
{
    public class ClienteService
    {
       public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar()) return "Dados Inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);
            repo.EnviarEmail("empresa@empresa", cliente.Email.Endereco, "Bem vindo", "parabens");

            return "Sucesso";
        }
    }
}
