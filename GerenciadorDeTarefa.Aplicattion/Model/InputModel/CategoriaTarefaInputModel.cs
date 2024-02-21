using GerendiadorDeTarefa.Domain.categoriatarefa;
using GerendiadorDeTarefa.Domain.tarefa;

namespace GerenciadorDeTarefa.Aplicattion.Model.InputModel
{
    public class CategoriaTarefaInputModel
    {

        public int idCategoriaTarefa { get; set; }
        public Tarefa IdTarefa { get; set; }
        public EnumCategoriaTarefa EnumCategoriaTarefa { get; set; }
        public string CategoriaTarefaDescricao { get; set; }

    }
}
