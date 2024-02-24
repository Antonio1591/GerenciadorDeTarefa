using GerenciadorDeTarefa.Infrastructure.Data;
using GerendiadorDeTarefa.Domain;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefa.Infrastructure.Repositorio
{
    public interface IPessoaRepository
    {
        public bool CadastrarPessoa(Pessoa tarefa);
        public Task<bool> AtualizarPessoa(Pessoa tarefa);
        public IEnumerable<Pessoa> BuscarPessoas();
        public Pessoa BuscarPessoaId(int id);
    }

    public class PessoaRepository : IPessoaRepository
    {
        private readonly DataContext _context;

        public PessoaRepository(DataContext dataCotnext)
        {
            _context = dataCotnext;
        }

        public bool CadastrarPessoa(Pessoa pessoa)
        {
              _context.Pessoa.Add(pessoa);

             _context.SaveChanges();
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
            return _context.Pessoa.ToList(); 

        }

        public Pessoa BuscarPessoaId(int id)
        {
            var pessoa =  _context.Pessoa.FirstOrDefault(I => I.IdPessoa == id);

            return pessoa;
        }

    }
}
