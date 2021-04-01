using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Pilares_oop
{

    // A ideia é oferecer um conjunto de estado e comportamentos a aherdando
    // Seria uma base para outras classes
    // Apenas pode ser herdada, nunca instanciada
    public abstract class EletroDomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        public EletroDomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        // metodos abstratos
        // Significa que voce não é obrigado a programa o comportamento
        // A classe que vai implementar o comportamento é a que esta herdando
        public abstract void Ligar();
        public abstract void desligar();

        // Nao abstrata
        // Porem o virtual deixa o método livre para sobreescrever, porem tem quer ter um comportamenoto base
        public virtual void Testar() 
        { 
            // Teste do equipamento
        }
    }
}
