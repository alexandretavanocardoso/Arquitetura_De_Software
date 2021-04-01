using OOP.Pilares_oop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Heranca_VS_Composicao
{
    public class Case
    {
        // Composição é melhor que herança
        #region Caso 1

        // Herança
        // Ideal da herança é a classe ser "compativel" com a classe a ser herdada
        public class PessoaFisica : Pessoa
        {
            public string Cpf { get; set; }
        }

        // Composição
        public class PessoaFisica2
        {
            public Pessoa Pessoa { get; set; }
            public string Cpf { get; set; }
        }

        public class TestesHerancaComposicao
        {
            public TestesHerancaComposicao()
            {
                var pessoaHeranca = new PessoaFisica
                {
                    Nome = "Joao",
                    DataNascimento = DateTime.Now,
                    Cpf = "32165498765"
                };

                var pessoaComposicao = new PessoaFisica2
                {
                    Pessoa = new Pessoa
                    {
                        Nome = "Joao",
                        DataNascimento = DateTime.Now,
                    },
                    Cpf = "32165498765"
                };

                var nomeHeranca = pessoaHeranca.Nome;
                var nomeComposicao = pessoaComposicao.Pessoa.Nome;
            }
        }

        #endregion

        #region Caso 2

        public interface IRepositorio<T>
        {
            void Adicionar(T obj);

            void Excluir(T obj);
        }

        public interface IRepositorioPessoa
        {
            void Adicionar(Pessoa obj);
        }

        public class Repositorio<T> : IRepositorio<T>
        {
            public void Adicionar(T obj)
            {

            }

            public void Excluir(T obj)
            {

            }
        }

        public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
        {

        }

        public class RepositorioComposicaoPessoa : IRepositorioPessoa
        {
            private readonly IRepositorio<Pessoa> _repositorioPessoa;

            public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
            {
                _repositorioPessoa = repositorioPessoa;
            }

            public void Adicionar(Pessoa obj)
            {
                _repositorioPessoa.Adicionar(obj);
            }
        }

        public class TestesHerancaComposicao2
        {
            public TestesHerancaComposicao2()
            {
                var repoH = new RepositorioHerancaPessoa();
                repoH.Adicionar(new Pessoa());
                repoH.Excluir(new Pessoa());

                var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
                repoC.Adicionar(new Pessoa());
            }
        }

        #endregion

    }
}
