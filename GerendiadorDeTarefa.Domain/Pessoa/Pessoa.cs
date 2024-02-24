using System.ComponentModel.DataAnnotations;

namespace GerendiadorDeTarefa.Domain
{

    public class Pessoa : Entidade
    {
        protected Pessoa() { }
       
        public Pessoa(string pessoanome, string cpf, DateTime datanascimento, string telefone)
        {

            var validarparametros = ValidarParametros(pessoanome,cpf,datanascimento,telefone);

            if (!validarparametros)
                return;

            PessoaNome = pessoanome;
            CPF= cpf;
            DataNascimento=datanascimento;
            Telefone= telefone;
        }


        [Key]
        public int IdPessoa { get;  set; }
        public string PessoaNome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }

        private bool ValidarParametros(string pessoanome, string cpf, DateTime datanascimento, string telefone)
        {
            if(string.IsNullOrEmpty(pessoanome))
                AddErro("O nome não pode ser vazio.");

            if (string.IsNullOrEmpty(cpf))
                AddErro("O CPF não pode ser vazio.");

            if (datanascimento < DateTime.Now.AddYears(-120))
                AddErro("Data de início não pode ter um inicio de 1 ano atrás");

            if (string.IsNullOrEmpty(telefone))
                AddErro("O telefone não pode ser vazio.");

            return EhValido ? true : false;


        }

        

    }
}