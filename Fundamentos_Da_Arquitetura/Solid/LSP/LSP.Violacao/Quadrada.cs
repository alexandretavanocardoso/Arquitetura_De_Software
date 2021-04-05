using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.LSP.LSP.Violacao
{
    public class Quadrada : Retangulo
    {
        public override double Altura
        {
            set { base.Altura = base.Largura = value; }
        }


        public override double Largura
        {
            set { base.Altura = base.Largura = value; }
        }
    }
}
