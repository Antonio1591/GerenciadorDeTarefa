using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerendiadorDeTarefa.Domain.InputModel
{
    public class PessoaInputModelDomain
    {
        public int IdPessoa { get;  set; }
        public string PessoaNome { get;  set; }
        public string CPF { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public string Telefone { get;  set; }
    }
}
