using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Models
{
    public class MestrePokemon
    {
        [Required]
        public string Nome { get; set; }
        public int Idade { get; set; }
        [Key]
        [Required]
        public string Cpf { get; set; }
    }
}
