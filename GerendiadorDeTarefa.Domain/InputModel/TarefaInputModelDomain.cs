using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerendiadorDeTarefa.Domain.InputModel
{
    public class TarefaInputModelDomain
    {
        public int TarefaId { get; set; }
        public Pessoa ResponsavelTarefa { get; set; }
        public string TarefaDescriscao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataConclusaoEsperada { get; set; }
        public DateTime DataConclusao { get; set; }
        public EnumCategoriaTarefa EnumCategoriaTarefa { get; set; }
        public string CategoriaTarefaDescricao { get; set; }
        public EnumPrioridadeTarefa EnumPrioridadeEnum { get; set; }
        public string PrioridadeDescriscao { get; set; }
        public EnumStatusTarefa Status { get; set; }
        public bool TarefaConcluida { get; set; }
    }
}
