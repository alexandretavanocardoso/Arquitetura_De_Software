using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.LSP.LSP.Violacao
{
    public class CalculaArea
    {
        private static void obterAreaRetanculo(Retangulo ret)
        {
            Console.Clear();
            Console.WriteLine("calculo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + "*" + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrada()
            {
                Altura = 10,
                Largura = 5
            };

            obterAreaRetanculo(quad);
        }


    }
}
