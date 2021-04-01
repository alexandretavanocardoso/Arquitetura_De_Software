using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Pilares_oop
{
    // Herança é quando herdamos outra classe, Interface, Controller
    // Herdamos os dados de outra classe, extendendo a classe herdada
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        // Podemos usar normalmente os estados de outra classe
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "Alexandre Tavano Cardoso",
                DataNascimento = Convert.ToDateTime("2002/08/08"),
                DataAdmissao = DateTime.Now,
                Registro = "012345"
            };

            funcionario.CalcularIdade();
        }
    }
}
