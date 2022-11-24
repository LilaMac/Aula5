using CursosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CursosMVC.Data
{
    public class CursoContext : DbContext
    {
        public CursoContext(DbContextOptions<CursoContext> options) : base(options)
        { }

        public DbSet<Curso> Cursos { get; set; } = null!;
    }
}