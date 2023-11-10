using Disciplinas.Data.Context;
using Disciplinas.Models;

namespace Disciplinas.Repository
{
    public class DisciplinaRepository
    {
        private readonly BdContext _bdContext;

        public DisciplinaRepository(BdContext bdContext)
        {
            _bdContext = bdContext;
        }

        public Disciplina CadastrarDisciplina(Disciplina disciplina)
        {
            _bdContext.Disciplina.Add(disciplina);
            _bdContext.SaveChanges();
            return disciplina;
        }

        public List<Disciplina> ListarDisciplinas()
        {
            return _bdContext.Disciplina.ToList();
        }

        public Disciplina ExcluirDisciplina(int codigo)
        {
            var _disciplinaExcluida = _bdContext.Disciplina.FirstOrDefault(d => d.Codigo == codigo);

            if (_disciplinaExcluida == null)
            {
                return null;
            }

            _bdContext.Disciplina.Remove(_disciplinaExcluida);
            _bdContext.SaveChanges();
            return _disciplinaExcluida;
        }

        public List<Disciplina> ListarDisciplinaPorCodigo(int codigo)
        {
            return _bdContext.Disciplina.Where(d => d.Codigo == codigo).ToList();
        }

        public List<Disciplina> ListarDisciplinaPorCodigoProfessor(int codigo)
        {
            return _bdContext.Disciplina.Where(d => d.Professor.Codigo == codigo).ToList();
        }
    }
}
