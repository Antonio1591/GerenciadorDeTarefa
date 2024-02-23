using System.ComponentModel.DataAnnotations;

namespace GerendiadorDeTarefa.Domain
{

    public class Pessoa
    {
        protected Pessoa() { }
        public Pessoa(string nome,string cpf) 
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new DomainException("Erro ao cadastrar pessoa. Nome não informado");
            }
            if (string.IsNullOrEmpty(cpf))
            {
                throw new DomainException("Erro ao cadastrar CPF. Verifique os dados novamente!");
            }
        }

        [Key]
        public int IdPessoa { get; private set; }
        public string PessoaNome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
    }
}
