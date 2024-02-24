using GerenciadorDeTarefa.Aplicattion.Model.InputModel;
using GerenciadorDeTarefa.Aplicattion.RespostaApi;
using GerenciadorDeTarefa.Aplicattion.Services;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenciadorDeTarefasController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;

        [HttpPost("cadastrartarefa")]
        public ActionResult<RespostaApi<bool>> strarTarefa(TarefaInputModel tarefaInputModel)
        {
            var cadastratarefa =  _tarefaService.CadastrarTarefa(tarefaInputModel);

            if (cadastratarefa.Erro)
            {
                return BadRequest(cadastratarefa.MensagemErro);
            }

           return Ok();

        }


    }
}
