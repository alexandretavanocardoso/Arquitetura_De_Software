using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Classes_x_Objeto
{
    // Tudo que queremos representar no mundo real
    // Uma cópia do banco de dados
    public class Casa
    {
        public int Numero { get; set; }
        public int Andares { get; set; }
        public int Tamanho { get; set; }
        public decimal valor { get; set; }
    }

    // Classe sendo instanciada e alocada na mémoria
    public class Objeto
    {
        public Objeto()
        {
            var casa = new Casa()
            {
                Numero = 15,
                Andares = 2,
                Tamanho = 500,
                valor = 10000
            };
        }
    }
}
