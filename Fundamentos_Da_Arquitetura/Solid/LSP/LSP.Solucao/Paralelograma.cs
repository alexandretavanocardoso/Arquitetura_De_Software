using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.LSP.LSP.Solucao
{
    public abstract class Paralelograma
    {
        protected Paralelograma(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Altura { get; set; }
        public double Largura { get; set; }

        public double Area { get { return Altura * Largura; } }
    }
}
