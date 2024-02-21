
using GerendiadorDeTarefa.Domain.categoriatarefa;
using GerendiadorDeTarefa.Domain.pessoa;
using GerendiadorDeTarefa.Domain.prioridadetarefa;

namespace GerendiadorDeTarefa.Domain.tarefa
{
    public class Tarefa
    {
        protected Tarefa() { }
    public int TarefaId { get; private set; }
    public Pessoa ResponsavelTarefa { get; private set; }
    public string TarefaDescriscao { get; private set; }
    public DateTime DataInicio { get; private set; }
    public DateTime DataConclusaoEsperada { get; private set; }
    public DateTime DataConclusao { get; private set; }
    public CategoriaTarefa CategoriaTarefa { get; private set; }
    public PrioridadeTarefa PrioridadeTarefa { get; private set; }
    public EnumStatusTarefa Status { get; private set; }
    public bool TarefaConcluida { get; private set; }
}
}