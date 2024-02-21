using GerendiadorDeTarefa.Domain.categoriatarefa;
using GerendiadorDeTarefa.Domain.pessoa;
using GerendiadorDeTarefa.Domain.prioridadetarefa;
using GerendiadorDeTarefa.Domain.tarefa;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefa.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Pessoa> pessoa { get; set; }
        public DbSet<Tarefa> tarefa { get; set; }
        public DbSet<CategoriaTarefa> categoriaTarefas { get; set; }
        public DbSet<PrioridadeTarefa> prioridadeTarefa { get; set; }

    }
}
