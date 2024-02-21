using GerendiadorDeTarefa.Domain.tarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefa.Aplicattion.Model.ViewModel
{
    public class TarefaViewModel
    {
        public string TarefaDescriscao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataConclusaoEsperada { get; set; }
        public DateTime DataConclusao { get; set; }
        public string CategoriaTarefa { get; set; }
        public string CategoriaTarefaDescriscao { get; set; }
        public string PrioridadeTarefa { get; set; }
        public string PrioridadeDescriscao { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}
