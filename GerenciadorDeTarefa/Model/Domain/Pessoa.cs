using GerenciadorDeTarefa.Domain.Model;

namespace GerenciadorDeTarefa.Domain.Model
{
    public class Pessoa
    {
        public int IdPessoa { get; private set; }
        public string PessoaNome { get; private set; }
        public string PessoaSex { get; private set; }
        public string CPF {  get; private set; }
        public DateOnly DataNascimento { get; private set; }
        public string Telefone {  get; private set; } 

    }
}
