using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerendiadorDeTarefa.Domain.prioridadetarefa
{
    public class PrioridadeTarefa
    {
        protected PrioridadeTarefa() { }
        [Key]
        public int IdPrioridadeTarefa { get; private set; }
        public EnumPrioridadeTarefa EnumPrioridadeEnum { get; private set; }
        public string PrioridadeDescriscao { get; private set; }

    }
}
