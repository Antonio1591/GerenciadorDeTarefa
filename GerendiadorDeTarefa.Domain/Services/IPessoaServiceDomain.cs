using GerendiadorDeTarefa.Domain.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerendiadorDeTarefa.Domain.Services
{
    public interface IPessoaServiceDomain
    {
        public RespostaDomain<Pessoa> CriarPessoa(PessoaInputModelDomain input);
        public RespostaDomain<bool> BuscarPessoaId(int id);
        public Task<RespostaDomain<Pessoa>> EditarPessoa(PessoaInputModelDomain input);
        public Task<RespostaDomain<Pessoa>> DeletarPessoa(PessoaInputModelDomain input);

    }
    public class PessoaServiceDomain : IPessoaServiceDomain
    {
        public RespostaDomain<Pessoa> CriarPessoa(PessoaInputModelDomain input)
        {
            var PessoaInput = new Pessoa(input.PessoaNome, input.CPF, input.DataNascimento, input.Telefone);
            if (!PessoaInput.EhValido)
            {
                return new RespostaDomain<Pessoa>
                {
                    MensagemErro = PessoaInput.Erros,
                    Erro = true

                };
            }
            else
            {
                return new RespostaDomain<Pessoa>
                {
                    Dados = PessoaInput,
                    Erro = false

                };

            }

        }

        public RespostaDomain<bool> BuscarPessoaId(int id)
        {
            if (id <= 0)
            {
                return new RespostaDomain<bool>
                {
                    Erro = true,
                    MensagemErro = new List<string> { "Digite um Id Válido para continuar sua consulta." }
                };
            }
            else
            {
                return new RespostaDomain<bool>
                {
                    Dados = true
                };
            }


        }
        public Task<RespostaDomain<Pessoa>> EditarPessoa(PessoaInputModelDomain input)
        {
            throw new NotImplementedException();
        }

        public Task<RespostaDomain<Pessoa>> DeletarPessoa(PessoaInputModelDomain input)
        {
            throw new NotImplementedException();
        }
    }
}
