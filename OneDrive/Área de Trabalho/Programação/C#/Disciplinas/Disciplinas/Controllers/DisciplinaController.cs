using Disciplinas.Models;
using Disciplinas.Services;
using Microsoft.AspNetCore.Mvc;

namespace Disciplinas.Controllers
{
    public class DisciplinaController : ControllerBase
    {
        private readonly DisciplinaService _disciplinaService;

        public DisciplinaController(DisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }

        [HttpPost]
        [Route("CadastrarDisciplina")]
        public IActionResult CadastrarDisciplinas(Disciplina disciplina)
        {
            return Ok(_disciplinaService.CadastrarDisciplina(disciplina));
        }

        [HttpGet]
        [Route("ListarDisciplinas")]
        public IActionResult ListaDeDisciplinas()
        {
            return Ok(_disciplinaService.ListarDisciplinas());
        }

        [HttpDelete]
        [Route("ExcluirDisciplina")]
        public IActionResult ExcluirDisciplinaCodigo(int codigo)
        {
            var disciplinaExcluida = _disciplinaService.ExcluirDisciplina(codigo);

            if (disciplinaExcluida != null)
            {
                return Ok(disciplinaExcluida);
            }
            return BadRequest("Erro ao excluir disciplina");
        }

        [HttpGet]
        [Route("ListarDisciplinaPorCodigo")]
        public IActionResult ListarDisciplinaPorCodigo(int codigo)
        {
            return Ok(_disciplinaService.ListarDisciplinaPorCodigo(codigo));
        }

        [HttpGet]
        [Route("ListarDisciplinaPorCodigoProfessor")]
        public IActionResult ListarDisciplinaPorCodigoProfessor(int codigo)
        {
            return Ok(_disciplinaService.ListarDisciplinaPorCodigoProfessor(codigo));
        }
    }
}
