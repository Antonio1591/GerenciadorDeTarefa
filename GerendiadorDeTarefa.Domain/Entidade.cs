using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerendiadorDeTarefa.Domain
{
    public abstract class Entidade
    {
        public List<string> Erros = new List<string>();

        public void AddErro(string erro)
        {
            Erros.Add(erro);

        }

        [NotMapped]
        public bool EhValido => !Erros.Any();

    }
}
