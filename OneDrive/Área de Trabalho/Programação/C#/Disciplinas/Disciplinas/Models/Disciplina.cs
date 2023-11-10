using System.ComponentModel.DataAnnotations;

namespace Disciplinas.Models
{
    public class Disciplina
    {
        [Key]
        public int Codigo { get; set; }
        public int CargaHoraria { get; set; }
        public string Nome { get; set; }
        public int Horario { get; set; }
        public Professor Professor { get; set; }
    }
}
