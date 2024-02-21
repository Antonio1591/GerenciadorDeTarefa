using GerendiadorDeTarefa.Domain.prioridadetarefa;
using GerendiadorDeTarefa.Domain.tarefa;

namespace GerenciadorDeTarefa.Aplicattion.Model.InputModel
{
    public class PrioridadeTarefaInputModel
    {
        public int IdPrioridadeTarefa { get; set; }
        public Tarefa IdTarefa { get; set; }
        public EnumPrioridadeTarefa EnumPrioridadeEnum { get; set; }
        public string PrioridadeDescriscao { get; set; }

    }
}
