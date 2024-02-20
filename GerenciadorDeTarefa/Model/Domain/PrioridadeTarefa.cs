using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeTarefa.Domain.Model
{
    public class PrioridadeTarefa
    {
        protected PrioridadeTarefa() { }
        [Key]
        public int IdPrioridadeTarefa { get; private set;}
        public EnumPrioridadeTarefa EnumPrioridadeEnum { get; private set; }
        public string PrioridadeDescriscao {  get; private set; }

    }
}
