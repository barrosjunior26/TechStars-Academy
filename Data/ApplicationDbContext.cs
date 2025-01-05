using Microsoft.EntityFrameworkCore;
using TechStars_Academy.Models;

namespace TechStars_Academy.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
		public DbSet<CadastroAluno> Tb_cadastroAlunos { get; set; }
		public DbSet<AcessoPortal> Tb_acessoPortals { get; set; }
		public DbSet<Carreiras> Tb_carreiras { get; set; }
	}
}
