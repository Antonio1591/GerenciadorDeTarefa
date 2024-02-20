using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeTarefa.Domain.Model
{
    public class CategoriaTarefa
    {
        protected CategoriaTarefa(){ }

        [Key]
        public int idCategoriaTarefa { get; private set; }
        public EnumCategoriaTarefa EnumCategoriaTarefa { get; private set; }
        public string CategoriaTarefaDescricao { get; private set; }

    }
}
