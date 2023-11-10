using PokemonAPI.Models;
using PokemonAPI.Repository;

namespace PokemonAPI.Services
{
    public class PokemonServices
    {
        private readonly PokemonRepository _pokemonRepository;

        public PokemonServices(PokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        public Pokemon CadastrarPokemon(Pokemon pokemon)
        {
            return _pokemonRepository.CadastrarPokemon(pokemon);
        }

        public List<Pokemon> ListarPokemons()
        {
            return _pokemonRepository.ListarPokemons();
        }

        public List<Pokemon> Get10Pokemons(int v)
        {
            return _pokemonRepository.Get10Pokemons();
        }

        public List<Pokemon> ListarPokemonsCodigo(int codigo)
        {
            return _pokemonRepository.ListarPokemonsCodigo(codigo);
        }

        public Pokemon ExcluirPokemons(int codigo)
        {
            return _pokemonRepository.ExcluirRepository(codigo);
        }

        public Pokemon AtualizarPokemon(Pokemon pokemon)
        {
            return _pokemonRepository.AtualizarPokemon(pokemon);
        }

    }
}
