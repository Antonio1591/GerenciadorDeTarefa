using GerendiadorDeTarefa.Domain;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefa.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Pessoa> pessoa { get; set; }
        public DbSet<Tarefa> tarefa { get; set; }

    }
}
