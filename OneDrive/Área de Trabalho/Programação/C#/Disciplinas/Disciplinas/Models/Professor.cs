using System.ComponentModel.DataAnnotations;

namespace Disciplinas.Models
{
    public class Professor
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int DataNascimento { get; set; }
    }
}
