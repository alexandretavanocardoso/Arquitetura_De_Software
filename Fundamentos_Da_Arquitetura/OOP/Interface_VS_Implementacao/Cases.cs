using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Interface_VS_Implementacao
{
    // Melhor usar uma interface
    // Especie de contrato simples, obriga a declarar os metodos da classe pai
    public interface IRepository
    {
        void Adicionar();
    }

    // Abstracao do uso da classe
    // Fazendo um contrato simples e usando Depency Injection
    // melhor modo de usar
    public class UsoAbstracao
    {
        private readonly IRepository _repository;

        public UsoAbstracao(IRepository repository)
        {
            _repository = repository;
        }

        public void Processo()
        {
            _repository.Adicionar();
        }
    }

    public class Repositorio : IRepository
    {
        public void Adicionar()
        {

        }
    }

    // usado para teste - apenas simular
    public class RepositorioFake : IRepository
    {
        public void Adicionar()
        {

        }
    }

    // Implementacao
    // Cria uma instancia e usa os metodos
    public class UsoImplementacao
    {
        public void Precesso()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Precesso();

            var repoAbs = new UsoAbstracao(new Repositorio());
            repoAbs.Processo();

            var repoFake = new UsoAbstracao(new RepositorioFake());
            repoFake.Processo();
        }
    }
}
