using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.OCP.OCP.Solucao
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        public abstract string Debitar(decimal valor, string conta);

        public string FormataTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            // Numero transcao formatado
            return NumeroTransacao;
        }
    }
}
