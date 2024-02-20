using GerenciadorDeTarefa.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefa.data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options) { }
        public DbSet<Pessoa>pessoa { get; set; }
        public DbSet<Tarefa> tarefa { get; set; }
        public DbSet<CategoriaTarefa> categoriaTarefas { get; set; }
        public DbSet<PrioridadeTarefa> prioridadeTarefa { get; set; }
       
    }
}
