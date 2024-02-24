using GerenciadorDeTarefa.Aplicattion.Model.ViewModel;
using GerendiadorDeTarefa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefa.Aplicattion.Model.Mapping
{
    public static class PessoaMapping
    {
        public static PessoaViewModel ParaViewModel(this Pessoa pessoa)
        {
            return new PessoaViewModel
            {
                PessoaNome=pessoa.PessoaNome,
                Telefone=pessoa.Telefone,
                DataNascimento=pessoa.DataNascimento,
            };
        }
    }
}
