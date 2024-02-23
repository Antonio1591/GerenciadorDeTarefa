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
        public RespostaDomain<Pessoa> CriaPessoa(PessoaInputModelDomain input);
        public Task<RespostaDomain<Pessoa>> EditarTarefa(PessoaInputModelDomain input);
        public Task<RespostaDomain<Pessoa>> DeletarTarefa(PessoaInputModelDomain input);

    }
    public class PessoaServiceDomain : IPessoaServiceDomain
    {
        public RespostaDomain<Pessoa> CriarTarefa(PessoaInputModelDomain input)
        {
            //var cadastrartarefa = new Tarefa(input.ResponsavelTarefa, input.TarefaDescriscao, input.DataInicio, input.DataConclusaoEsperada, input.EnumCategoriaTarefa, input.CategoriaTarefaDescricao, input.EnumPrioridadeEnum, input.PrioridadeDescriscao, input.Status, input.TarefaConcluida);
            //if (!cadastrartarefa.EhValido)
            //{
            //    return new RespostaDomain<Tarefa>
            //    {
            //        MensagemErro = cadastrartarefa.Erros,
            //        Erro = true

            //    };
            //}
            //else
            //{
            //    return new RespostaDomain<Tarefa>
            //    {
            //        Dados = cadastrartarefa,
            //        Erro = false

            //    };

            //}

        }

        public Task<RespostaDomain<Pessoa>> DeletarTarefa(PessoaInputModelDomain input)
        {
            throw new NotImplementedException();
        }

        public Task<RespostaDomain<Pessoa>> EditarTarefa(PessoaInputModelDomain input)
        {
            throw new NotImplementedException();
        }
    }
}
