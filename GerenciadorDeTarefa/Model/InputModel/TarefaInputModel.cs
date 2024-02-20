using GerenciadorDeTarefa.Domain.Model;

namespace GerenciadorDeTarefa.Domain.InputModel
{
    public class TarefaInputModel
    {
        public int TarefaId { get;  set; }
        public Pessoa ResponsavelTarefa { get;  set; }
        public string TarefaDescriscao { get;  set; }
        public DateTime DataInicio { get;  set; }
        public DateTime DataConclusaoEsperada { get;  set; }
        public DateTime DataConclusao { get;  set; }
        public CategoriaTarefa CategoriaTarefa { get;  set; }
        public PrioridadeTarefa PrioridadeTarefa { get;  set; }
        public EnumStatusTarefa Status { get;  set; }
        public bool TarefaConcluida { get; set; }
    
    }
}
