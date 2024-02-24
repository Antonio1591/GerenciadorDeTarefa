using GerenciadorDeTarefa.Aplicattion.Model.InputModel;
using GerenciadorDeTarefa.Aplicattion.Model.ViewModel;
using GerenciadorDeTarefa.Aplicattion.RespostaApi;
using GerenciadorDeTarefa.Aplicattion.Services;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaservice;

        public PessoaController(IPessoaService pessoaservice)
        {
            _pessoaservice = pessoaservice;
        }

        [HttpPost("CadastrarPessoa")]
        public ActionResult<RespostaApi<bool>>  CadastrarPessoa(PessoaInputModel pessoainputmodel)
        {
            var pessocadastrada = _pessoaservice.CadastrarPessoa(pessoainputmodel);

            if (pessocadastrada.Erro)
            {
                return BadRequest(pessocadastrada.MensagemErro);
            }

            return Ok();

        }

        [HttpGet("buscarpessoaid")]
        public ActionResult<RespostaApi<PessoaViewModel>> BuscarPorId(int id)
        {
            var buscarpessoa = _pessoaservice.BuscarPorId(id);

            if (buscarpessoa.Erro)
            {
                return BadRequest(buscarpessoa.MensagemErro);
            }

            return new RespostaApi<PessoaViewModel>
            {
                Dados = buscarpessoa.Dados,
            };

        }

    }
}
