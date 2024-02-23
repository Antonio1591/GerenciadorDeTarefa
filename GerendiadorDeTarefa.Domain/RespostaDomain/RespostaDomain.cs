using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerendiadorDeTarefa.Domain
{
    public class RespostaDomain<TViewerModel>
    {
        public TViewerModel Dados { get; set; }
        public bool Erro { get; set; }
        public List<string> MensagemErro { get; set; }
    }
}

