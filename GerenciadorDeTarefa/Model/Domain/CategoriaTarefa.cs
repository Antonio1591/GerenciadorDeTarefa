namespace GerenciadorDeTarefa.Domain.Model
{
    public class CategoriaTarefa
    {

        public int idCategoriaTarefa { get; private set; }
        public Tarefa IdTarefa { get; private set; }
        public EnumCategoriaTarefa EnumCategoriaTarefa { get; private set; }
        public string CategoriaTarefaDescricao { get; private set; }

    }
}
