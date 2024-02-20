namespace GerenciadorDeTarefa.Domain.Model
{
    public class Tarefa
    {
        public int TarefaId { get; private set; }
        public Pessoa ResponsavelTarefa { get; private set; }
        public string TarefaDescriscao { get; private set; }
        public DateTime DataInicio {  get; private set; }
        public DateTime DataConclusaoEsperada {  get; private set; }
        public DateTime DataConclusao {  get; private set; }
        public CategoriaTarefa CategoriaTarefa {  get; private set; }
        public PrioridadeTarefa PrioridadeTarefa { get; private set; }
        public EnumStatusTarefa Status { get; private set; }
        public bool TarefaConcluida { get; private set; }
    }
}
