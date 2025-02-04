using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<EmprestimoLivros.Models.EmprestimosModel> Emprestimos { get; set; }

        public DbSet<EmprestimoLivros.Models.UsuarioModel> Usuarios { get; set; }

    }
}
