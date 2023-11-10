using PokemonAPI.Data.Context;
using PokemonAPI.Models;

namespace PokemonAPI.Repository
{
    public class PokemonRepository
    {
        private readonly PokemonContext _pokemonContext;

        public PokemonRepository(PokemonContext pokemonContext)
        {
            _pokemonContext = pokemonContext;
        }

        public Pokemon CadastrarPokemon(Pokemon pokemon)
        {
            _pokemonContext.Pokemon.Add(pokemon);
            _pokemonContext.SaveChanges();
            return pokemon;
        }

        public List<Pokemon> ListarPokemons()
        {
            return _pokemonContext.Pokemon.ToList(); //código de retornar somente 10 aleatórios.
        }

        public List<Pokemon> ListarPokemonsCodigo(int codigo)
        {
            return _pokemonContext.Pokemon.Where(p => p.Codigo == codigo).ToList();
        }
        public Pokemon ExcluirRepository(int codigo)
        {
            var pokemonExcluido = _pokemonContext.Pokemon.FirstOrDefault(p => p.Codigo == codigo);

            if (pokemonExcluido != null)
            {
                _pokemonContext.Pokemon.Remove(pokemonExcluido);
                _pokemonContext.SaveChanges();
            }
            return pokemonExcluido;
        }

        public Pokemon AtualizarPokemon(Pokemon pokemon)
        {
            var pokemonAtualizado = _pokemonContext.Pokemon.FirstOrDefault(p => p == pokemon);

            if (pokemon != null)
            {
                pokemonAtualizado.Descricao = pokemon.Descricao;
                pokemonAtualizado.Habitat = pokemon.Habitat;
                pokemonAtualizado.Tipo = pokemon.Tipo;
                pokemonAtualizado.Nome = pokemon.Nome;
                pokemonAtualizado.Genero = pokemon.Genero;
                pokemonAtualizado.Habilidades = pokemon.Habilidades;

                _pokemonContext.Pokemon.Update(pokemonAtualizado);
                _pokemonContext.SaveChanges();
            }
            return pokemonAtualizado;
        }

        public List<Pokemon> Get10Pokemons()
        {
            return _pokemonContext.Pokemon.OrderBy(p => Guid.NewGuid()).Take(10).ToList();
        }
    }
}
