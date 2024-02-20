using GerenciadorDeTarefa.data;
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

        }
    }
}
