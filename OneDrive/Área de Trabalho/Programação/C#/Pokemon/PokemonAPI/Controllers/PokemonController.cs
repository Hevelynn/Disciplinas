using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Models;
using PokemonAPI.Services;

namespace PokemonAPI.Controllers
{
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokemonServices _pokemonServices;

        public PokemonController(PokemonServices pokemonServices)
        {
            _pokemonServices = pokemonServices;
        }

        [HttpPost]
        [Route("CadastrarPokemon")]
        public IActionResult CadastrarPokemon(Pokemon pokemon)
        {
            return Ok(_pokemonServices.CadastrarPokemon(pokemon));
        }

        [HttpGet]
        [Route("ListarPokemons")]
        public IActionResult ListarPokemons()
        {
            return Ok(_pokemonServices.ListarPokemons());
        }

        [HttpGet]
        [Route("Get10Pokemons")]
        public IActionResult Get10Pokemons()
        {
            return Ok(_pokemonServices.Get10Pokemons(10));
        }

        [HttpGet]
        [Route("ListarPokemonPorCodigo")]
        public IActionResult ListarPokemonsCodigo(int codigo)
        {
            return Ok(_pokemonServices.ListarPokemonsCodigo(codigo));
        }

        [HttpDelete]
        [Route("ExcluirPokemonPorCodigo")]
        public IActionResult ExcluirPokemon(int codigo)
        {
            if (ModelState.IsValid)
            {
                var pokemonExcluido = _pokemonServices.ExcluirPokemons(codigo);

                if (pokemonExcluido != null)
                {
                    return Ok(pokemonExcluido);
                }
                return BadRequest("Erro ao excluir pokémon!");
            }
            return BadRequest(ModelState);

        }

        [HttpPost]
        [Route("AtualizarPokemon")]
        public IActionResult AtualizarPokemon(Pokemon pokemon)
        {
            if (ModelState.IsValid)
            {
                var pokemonAtualizado = _pokemonServices.AtualizarPokemon(pokemon);

                if (pokemonAtualizado != null)
                {
                    return Ok(pokemonAtualizado);
                }
                return BadRequest("Erro ao atualizar pokémon");
            }
            return BadRequest(ModelState);
        }
    }
}
