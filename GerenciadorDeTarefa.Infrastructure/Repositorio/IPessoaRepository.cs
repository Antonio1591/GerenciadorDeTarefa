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
    public interface IPessoaRepository
    {
        public Task<bool> CadastrarPessoa(Pessoa tarefa);
        public Task<bool> AtualizarPessoa(Pessoa tarefa);
        public IEnumerable<Pessoa> BuscarPessoas();
        public Task<Pessoa> BuscarPessoaId(int id);
    }

    public class PessoaRepository : IPessoaRepository
    {
        private readonly DataContext _context;

        public PessoaRepository(DataContext dataCotnext)
        {
            _context = dataCotnext;
        }

        public async Task<bool> CadastrarPessoa(Pessoa tarefa)
        {
            await _context.AddAsync(tarefa);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AtualizarPessoa(Pessoa tarefa)
        {
            _context.Update(tarefa);
            await _context.SaveChangesAsync();
            return true;

        }

        public IEnumerable<Pessoa> BuscarPessoas()
        {
            return _context.pessoa.ToList(); ;

        }

        public async Task<Pessoa> BuscarPessoaId(int id)
        {
            return await _context.pessoa.FirstOrDefaultAsync(T => T.IdPessoa == id);
        }

    }
}
