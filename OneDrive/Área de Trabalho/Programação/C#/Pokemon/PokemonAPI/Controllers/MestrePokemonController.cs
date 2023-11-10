using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Models;
using PokemonAPI.Services;

namespace PokemonAPI.Controllers
{
    [ApiController]
    public class MestrePokemonController : ControllerBase
    {
        private readonly MestrePokemonServices _mestrePokemonServices;

        public MestrePokemonController(MestrePokemonServices mestrePokemonServices)
        {
            _mestrePokemonServices = mestrePokemonServices;
        }

        [HttpPost]
        [Route("CadastrarMestrePokemon")]
        public IActionResult CadastrarMestre(MestrePokemon mestrePokemon)
        {
            return Ok(_mestrePokemonServices.CadastrarMestre(mestrePokemon));
        }

        [HttpGet]
        [Route("ListaDeMestresPokemons")]
        public IActionResult ListarMestres()
        {
            return Ok(_mestrePokemonServices.ListarMestres());
        }

        [HttpGet]
        [Route("ListaDeMestresporCpf")]
        public IActionResult ListarMestresPorCpf(string cpf)
        {
            return Ok(_mestrePokemonServices.ListarMestresPorCpf(cpf));
        }

        [HttpDelete]
        [Route("ExcluirMestrePorCpf")]
        public IActionResult ExcluirMestre(string cpf)
        {
            if (ModelState.IsValid)
            {
                var mestreExcluido = _mestrePokemonServices.ExcluirMestre(cpf);
                if(mestreExcluido != null)
                {
                    return Ok(mestreExcluido);
                }
                return BadRequest("Erro ao excluir mestre pokémon!!!");
            }
            return BadRequest(ModelState);
        }
    }
}
