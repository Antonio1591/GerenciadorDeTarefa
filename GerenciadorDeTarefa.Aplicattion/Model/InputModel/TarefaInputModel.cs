using GerendiadorDeTarefa.Domain.categoriatarefa;
using GerendiadorDeTarefa.Domain.pessoa;
using GerendiadorDeTarefa.Domain.prioridadetarefa;
using GerendiadorDeTarefa.Domain.tarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefa.Aplicattion.Model.InputModel
{


    public class TarefaInputModel
    {
        public int TarefaId { get; set; }
        public Pessoa ResponsavelTarefa { get; set; }
        public string TarefaDescriscao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataConclusaoEsperada { get; set; }
        public DateTime DataConclusao { get; set; }
        public CategoriaTarefa CategoriaTarefa { get; set; }
        public PrioridadeTarefa PrioridadeTarefa { get; set; }
        public EnumStatusTarefa Status { get; set; }
        public bool TarefaConcluida { get; set; }

    }
}
