using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.ISP.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // Produto não tem e-mail - implemntando método que nao usa
            throw new NotImplementedException();
        }

        public void SalvarBanco()
        {
            throw new NotImplementedException();
        }

        public void ValidarDados()
        {
            throw new NotImplementedException();
        }
    }
}
