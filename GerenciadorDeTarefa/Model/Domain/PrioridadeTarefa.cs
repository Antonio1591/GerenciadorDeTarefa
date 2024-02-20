namespace GerenciadorDeTarefa.Domain.Model
{
    public class PrioridadeTarefa
    {
        public int IdPrioridadeTarefa { get; private set;}
        public Tarefa IdTarefa { get; private set; }
        public EnumPrioridadeTarefa EnumPrioridadeEnum { get; private set; }
        public string PrioridadeDescriscao {  get; private set; }

    }
}
