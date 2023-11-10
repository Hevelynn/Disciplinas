using Disciplinas.Models;
using Microsoft.EntityFrameworkCore;

namespace Disciplinas.Data.Context
{
    public class BdContext : DbContext
    {
        public BdContext(DbContextOptions<BdContext> options) : base(options)
        {

        }

        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Professor> Professor { get; set; }
    }
}
