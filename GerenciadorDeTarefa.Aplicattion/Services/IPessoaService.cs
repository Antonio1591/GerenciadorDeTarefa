using GerenciadorDeTarefa.Aplicattion.Model.InputModel;
using GerenciadorDeTarefa.Aplicattion.Model.ViewModel;
using GerenciadorDeTarefa.Aplicattion.RespostaApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefa.Aplicattion.Services
{
    public interface IPessoaService
    {
        public RespostaApi<bool> CadastrarTarefa(PessoaInputModel input);

        public RespostaApi<PessoaViewModel> BuscarPorId(int id);
    }
    public class PessoaService:IPessoaService
    { 

    }
}
