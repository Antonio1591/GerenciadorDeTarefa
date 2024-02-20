using GerenciadorDeTarefa.Domain.Model;

namespace GerenciadorDeTarefa.Domain.InputModel
{
    public class PrioridadeTarefaInputModel
    {
        public int IdPrioridadeTarefa { get;  set; }
        public Tarefa IdTarefa { get;  set; }
        public EnumPrioridadeTarefa EnumPrioridadeEnum { get;  set; }
        public string PrioridadeDescriscao { get;  set; }

    }
}
