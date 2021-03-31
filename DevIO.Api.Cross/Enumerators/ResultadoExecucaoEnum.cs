using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.Cross.Enumerators
{
    public enum ResultadoExecucaoEnum
    {
        NaoEspecificado = -1,
        Sucesso = 1,
        Erro = 2,
        SessaoInvalida = 3,
        NaoAutorizado = 4
    }
}
