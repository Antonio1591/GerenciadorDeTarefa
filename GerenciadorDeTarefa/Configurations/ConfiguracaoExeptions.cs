using GerenciadorDeTarefa.Aplicattion.Services;
using GerenciadorDeTarefa.Infrastructure.Data;
using GerenciadorDeTarefa.Infrastructure.Repositorio;
using GerendiadorDeTarefa.Domain.Services;
using Microsoft.EntityFrameworkCore;


namespace GerenciadorDeTarefa.Extenção
{
    public static class ConfiguracaoExtencao
    {
        public static void ConfiguracaoBancoDeDados(this IServiceCollection builder,IConfiguration configuration)
        {
            string stringConexao = configuration.GetConnectionString("conexaoMysql");

            builder.AddDbContext<DataContext>(opt =>
            opt.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao)).UseSnakeCaseNamingConvention());
        }

        public static void InjecaoDependencia(this IServiceCollection builder)
        {
            builder.AddScoped<ITarefaService, TarefaService>();
            builder.AddScoped<ITarefaRepository, TarefaRepository>();
            builder.AddScoped<ITarefaServicesDomain, TarefaServicesDomain>();
            builder.AddScoped<IPessoaService, PessoaService>();
            builder.AddScoped<IPessoaRepository, PessoaRepository>();
            builder.AddScoped<IPessoaServiceDomain, PessoaServiceDomain>();
        }
    }
}
