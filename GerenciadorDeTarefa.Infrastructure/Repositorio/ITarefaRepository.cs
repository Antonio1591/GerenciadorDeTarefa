using GerenciadorDeTarefa.Infrastructure.Data;
using GerendiadorDeTarefa.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefa.Infrastructure.Repositorio
{
    public interface ITarefaRepository
    {
        public Task<bool> CadastrarTarefa(Tarefa tarefa);
        public Task<bool> AtualizarTarefa(Tarefa tarefa);
        public IEnumerable<Tarefa> BuscarTarefas();
        public Task<Tarefa> BuscarTarefaId(int id);

    }

    public class TarefaRepository : ITarefaRepository
    {
        private readonly DataContext _context;

        public TarefaRepository(DataContext dataCotnext)
        {
            _context = dataCotnext;
        }

        public async Task<bool> CadastrarTarefa(Tarefa tarefa)
        {
            await _context.AddAsync(tarefa);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AtualizarTarefa(Tarefa tarefa)
        {
             _context.Update(tarefa);
            await _context.SaveChangesAsync();
            return true;

        }

        public  IEnumerable<Tarefa> BuscarTarefas()
        {
            return  _context.Tarefa.ToList(); ;
              
        }

        public async Task<Tarefa> BuscarTarefaId(int id)
        {
           return await _context.Tarefa.FirstOrDefaultAsync(T=>T.TarefaId == id);
        }

    }
}
