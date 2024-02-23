using GerenciadorDeTarefa.Aplicattion.Model.InputModel;
using GerenciadorDeTarefa.Aplicattion.Model.ViewModel;
using GerenciadorDeTarefa.Aplicattion.RespostaApi;
using GerenciadorDeTarefa.Infrastructure.Repositorio;
using GerendiadorDeTarefa.Domain;
using GerendiadorDeTarefa.Domain.InputModel;
using GerendiadorDeTarefa.Domain.Services;
using TarefaInputModel = GerenciadorDeTarefa.Aplicattion.Model.InputModel.TarefaInputModel;

namespace GerenciadorDeTarefa.Aplicattion.Services
{

    public interface ITarefaService
    {
        public RespostaApi<bool> CadastrarTarefa(TarefaInputModel input);
    }
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaServicesDomain _tarefaservicesdomain;
        private readonly ITarefaRepository _tarefasrepository;
        public RespostaApi<bool> CadastrarTarefa(TarefaInputModel input)
        {
            var inputDomain = new TarefaInputModelDomain
            {
                TarefaId = input.TarefaId,
                ResponsavelTarefa = input.ResponsavelTarefa,
                TarefaDescriscao = input.TarefaDescriscao,
                DataInicio = input.DataInicio,
                DataConclusaoEsperada = input.DataConclusaoEsperada,
                DataConclusao = input.DataConclusao,
                EnumCategoriaTarefa = input.EnumCategoriaTarefa,
                CategoriaTarefaDescricao = input.CategoriaTarefaDescricao,
                EnumPrioridadeEnum = input.EnumPrioridadeEnum,
                PrioridadeDescriscao = input.PrioridadeDescriscao,
                Status = input.Status,
                TarefaConcluida = input.TarefaConcluida
            };

            var cadastrartarefadomain = _tarefaservicesdomain.CriarTarefa(inputDomain);
           if(cadastrartarefadomain.Erro)
            {
                return new RespostaApi<bool>
                {
                    Erro = true,
                    MensagemErro=cadastrartarefadomain.MensagemErro 
                };
            }

           _tarefasrepository.CadastrarTarefa(cadastrartarefadomain.Dados);

            return new RespostaApi<bool>
            {
                Dados=true,
                Erro = false
            };

        }

    }
}

