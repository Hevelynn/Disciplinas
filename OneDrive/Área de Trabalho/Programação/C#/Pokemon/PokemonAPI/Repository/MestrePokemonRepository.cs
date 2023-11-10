using PokemonAPI.Data.Context;
using PokemonAPI.Models;

namespace PokemonAPI.Repository
{
    public class MestrePokemonRepository
    {
        private readonly PokemonContext _pokemonContext;

        public MestrePokemonRepository(PokemonContext pokemonContext)
        {
            _pokemonContext = pokemonContext;
        }

        public MestrePokemon CadastrarMestre(MestrePokemon mestrePokemon)
        {
            _pokemonContext.MestrePokemon.Add(mestrePokemon);
            _pokemonContext.SaveChanges();
            return mestrePokemon;
        }

        public List<MestrePokemon> ListarMestres()
        {
            return _pokemonContext.MestrePokemon.ToList();
        }

        public List<MestrePokemon> ListarMestresPorCpf(string cpf)
        {
            return _pokemonContext.MestrePokemon.Where(m => m.Cpf == cpf).ToList();
        }

        public MestrePokemon ExcluirMestre(string cpf)
        {
            var mestreExcluido = _pokemonContext.MestrePokemon.FirstOrDefault(m => m.Cpf == cpf);

            if (mestreExcluido != null)
            {
                _pokemonContext.MestrePokemon.Remove(mestreExcluido);
                _pokemonContext.SaveChanges();
            }
            return mestreExcluido;
        }
    }
}
