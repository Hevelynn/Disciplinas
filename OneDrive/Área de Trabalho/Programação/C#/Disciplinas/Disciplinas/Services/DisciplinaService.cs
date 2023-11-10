using Disciplinas.Models;
using Disciplinas.Repository;

namespace Disciplinas.Services
{
    public class DisciplinaService
    {
        private readonly DisciplinaRepository _disciplinaRepository;

        public DisciplinaService(DisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }

        public Disciplina CadastrarDisciplina(Disciplina disciplina)
        {
            return _disciplinaRepository.CadastrarDisciplina(disciplina);
        }

        public List<Disciplina> ListarDisciplinas()
        {
            return _disciplinaRepository.ListarDisciplinas();
        }

        public Disciplina ExcluirDisciplina(int codigo)
        {
            return _disciplinaRepository.ExcluirDisciplina(codigo);
        }

        public List<Disciplina> ListarDisciplinaPorCodigo(int codigo)
        {
            return _disciplinaRepository.ListarDisciplinaPorCodigo(codigo);
        }

        public List<Disciplina> ListarDisciplinaPorCodigoProfessor(int codigo)
        {
            return _disciplinaRepository.ListarDisciplinaPorCodigoProfessor(codigo);
        }
    }
}
