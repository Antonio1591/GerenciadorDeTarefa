using GerenciadorDeTarefa.Domain.Model;

namespace GerenciadorDeTarefa.Domain.InputModel
{
    public class CategoriaTarefaInputModel
    {

        public int idCategoriaTarefa { get;  set; }
        public Tarefa IdTarefa { get;  set; }
        public EnumCategoriaTarefa EnumCategoriaTarefa { get;  set; }
        public string CategoriaTarefaDescricao { get;  set; }

    }
}
