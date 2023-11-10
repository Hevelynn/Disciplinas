using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Models
{
    public class Pokemon
    {
        public Pokemon()
        {

        }

        public Pokemon(int codigo, string nome, string tipo, string habilidades, string genero, string habitat, string descricao)
        {
            Codigo = codigo;
            Nome = nome;
            Tipo = tipo;
            Habilidades = habilidades;
            Genero = genero;
            Habitat = habitat;
            Descricao = descricao;
        }

        [Key]
        public int Codigo { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Tipo { get; set; }
        public string Habilidades { get; set; }
        public string Genero { get; set; }
        public string Habitat { get; set; }
        public string Descricao { get; set; }
    }
}
