using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Pilares_oop
{
    // Poli-morfismo
    // Classe com Multiplos comportamentos
    // Polimorfismo é a capacidade de uma classe abstrata assumir diversos comportamentos conforme sua implementação.
    // Para podermos modificar o comportamento de um método ele precisa ser abstrato ou virtual.

    public class CafeteiraEspressa : EletroDomestico
    {
        // Construtor passando as prop da Eletro
        public CafeteiraEspressa(string nome, int voltagem) : base(nome, voltagem){}

        // Construtor passando valor fixo
        public CafeteiraEspressa() : base("Padrão", 220) {}

        private static void AquecerAgua() {}
        private static void MoerGraos() {}

        public void PrapararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
        }

        /* Metodos abstratos da classe EletroDomestico */
        // override - Sobreescreve o comportamento de uma classe base
        public override void desligar()
        {
           // Verificar Recepiente de agua
        }

        // override - Sobreescreve o comportamento de uma classe base
        public override void Ligar()
        {
            // Verificar Recepiente de agua
        }
    }
}
