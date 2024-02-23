using GerendiadorDeTarefa.Domain.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerendiadorDeTarefa.Domain.Services
{
    public interface  ITarefaServicesDomain
    {
        public RespostaDomain<Tarefa> CriarTarefa(TarefaInputModelDomain input);
        public Task<RespostaDomain<Tarefa>> EditarTarefa(TarefaInputModelDomain input);
        public Task<RespostaDomain<Tarefa>> DeletarTarefa(TarefaInputModelDomain input);
    }
    public class TarefaServicesDomain : ITarefaServicesDomain
    {
        public  RespostaDomain<Tarefa> CriarTarefa(TarefaInputModelDomain input)
        {
            var cadastrartarefa = new Tarefa(input.ResponsavelTarefa, input.TarefaDescriscao, input.DataInicio, input.DataConclusaoEsperada, input.EnumCategoriaTarefa, input.CategoriaTarefaDescricao, input.EnumPrioridadeEnum, input.PrioridadeDescriscao, input.Status,input.TarefaConcluida); 
            if(!cadastrartarefa.EhValido)
            {
                return new RespostaDomain<Tarefa>
                {
                    MensagemErro = cadastrartarefa.Erros,
                     Erro = true

                };
            }
            else
            {
                return new RespostaDomain<Tarefa>
                {
                    Dados = cadastrartarefa,
                    Erro = false

                };

            }

        }

        public Task<RespostaDomain<Tarefa>> DeletarTarefa(TarefaInputModelDomain input)
        {
            throw new NotImplementedException();
        }

        public Task<RespostaDomain<Tarefa>> EditarTarefa(TarefaInputModelDomain input)
        {
            throw new NotImplementedException();
        }
    }
}
