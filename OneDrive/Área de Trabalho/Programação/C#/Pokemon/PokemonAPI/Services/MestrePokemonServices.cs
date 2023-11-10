using PokemonAPI.Models;
using PokemonAPI.Repository;

namespace PokemonAPI.Services
{
    public class MestrePokemonServices
    {
        private readonly MestrePokemonRepository _mestrePokemonRepository;

        public MestrePokemonServices(MestrePokemonRepository mestrePokemonRepository)
        {
            _mestrePokemonRepository = mestrePokemonRepository;
        }

        public MestrePokemon CadastrarMestre(MestrePokemon mestrePokemon)
        {
            return _mestrePokemonRepository.CadastrarMestre(mestrePokemon);
        }

        public List<MestrePokemon> ListarMestres()
        {
            return _mestrePokemonRepository.ListarMestres();
        }

        public List<MestrePokemon> ListarMestresPorCpf(string cpf)
        {
            return _mestrePokemonRepository.ListarMestresPorCpf(cpf);
        }

        public MestrePokemon ExcluirMestre(string cpf)
        {
            return _mestrePokemonRepository.ExcluirMestre(cpf);
        }
    }
}
