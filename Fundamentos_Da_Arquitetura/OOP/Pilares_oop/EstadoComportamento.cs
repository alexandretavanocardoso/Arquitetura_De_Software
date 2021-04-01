using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Pilares_oop
{
    public class Pessoa
    {
        // Estados são as propriedades das classes
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        // Comportamento, quando voce gera ou processa uma nova informação com os estados da classe
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}
