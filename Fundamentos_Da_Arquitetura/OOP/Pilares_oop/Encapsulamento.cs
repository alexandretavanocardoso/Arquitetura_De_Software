using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Pilares_oop
{
    // Arte de encapsular comportamentos atraves de metodos
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.PrapararCafe();
            espresso.desligar();
        }
    }
}
