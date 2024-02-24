using GerenciadorDeTarefa.Aplicattion.Model.InputModel;
using GerenciadorDeTarefa.Aplicattion.Model.Mapping;
using GerenciadorDeTarefa.Aplicattion.Model.ViewModel;
using GerenciadorDeTarefa.Aplicattion.RespostaApi;
using GerenciadorDeTarefa.Infrastructure.Repositorio;
using GerendiadorDeTarefa.Domain.InputModel;
using GerendiadorDeTarefa.Domain.Services;

namespace GerenciadorDeTarefa.Aplicattion.Services
{
    public interface IPessoaService
    {
        public RespostaApi<bool> CadastrarPessoa(PessoaInputModel input);

        public RespostaApi<PessoaViewModel> BuscarPorId(int id);
    }
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoarepository;
        private readonly IPessoaServiceDomain _pessoasericesdomain;

        public PessoaService(IPessoaRepository pessoarepository, IPessoaServiceDomain pessoasericesdomain)
        {
            _pessoarepository = pessoarepository;
            _pessoasericesdomain = pessoasericesdomain;
        }

        public RespostaApi<bool> CadastrarPessoa(PessoaInputModel input)
        {
            var inputDomain = new PessoaInputModelDomain
            {
                PessoaNome = input.PessoaNome,
                CPF = input.CPF,
                DataNascimento = input.DataNascimento,
                Telefone = input.Telefone
            };

            var cadastrarpessoadomain = _pessoasericesdomain.CriarPessoa(inputDomain);
            if (cadastrarpessoadomain.Erro)
            {
                return new RespostaApi<bool>
                {
                    Erro = true,
                    MensagemErro = cadastrarpessoadomain.MensagemErro
                };
            }

            var cadastroBanco = _pessoarepository.CadastrarPessoa(cadastrarpessoadomain.Dados);
            if (cadastroBanco == null)
            {

                return new RespostaApi<bool>
                {
                    Erro = true,
                    MensagemErro = cadastrarpessoadomain.MensagemErro
                };

            }


            return new RespostaApi<bool>
            {
                Dados = true,
                Erro = false
            };

        }
        public RespostaApi<PessoaViewModel> BuscarPorId(int id)
        {
            var BuscarPessoaId = _pessoasericesdomain.BuscarPessoaId(id);
            if (BuscarPessoaId.Erro)
            {
                return new RespostaApi<PessoaViewModel>
                {
                    Erro = true,
                    MensagemErro = BuscarPessoaId.MensagemErro
                };
            }

            var retornobanco = _pessoarepository.BuscarPessoaId(id);

            if (retornobanco == null)
            {
                return new RespostaApi<PessoaViewModel>
                {
                    Erro = true,
                    MensagemErro = new List<string> { "Usuario não encontrado!" },
                };
            }
            else
            {
                return new RespostaApi<PessoaViewModel>
                {
                    Erro = false,
                    Dados = retornobanco.ParaViewModel()
                };
            }
        }
    }
}
