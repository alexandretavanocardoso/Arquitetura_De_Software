using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.LSP.LSP.Violacao
{
    public class Retangulo
    {
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }
        public double Area { get { return Altura * Largura; } }
    }
}
