using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.LSP.LSP.Solucao
{
    public class Quadrada : Paralelograma
    {
        public Quadrada(int altura, int largura) : base(altura, largura)
        {
            if(largura != altura)
            {
                throw new Exception("Os dois lados precisam ser iguais");
            }
        }
    }
}
