using Microsoft.EntityFrameworkCore;
using TechStars_Academy.Models;

namespace TechStars_Academy.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
		public DbSet<CadastroAlunoModel> tb_cadastroAluno { get; set; }
		public DbSet<CarreirasModel> tb_carreiras { get; set; }
	}
}
