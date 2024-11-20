using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TechStars_Academy.Data;
using TechStars_Academy.Models;

namespace TechStars_Academy.Controllers
{
	public class PortalController : Controller
	{
		private readonly ApplicationDbContext _context;
		public PortalController(ApplicationDbContext db)
		{
			_context = db;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult CadastroAluno()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Carreiras(string pesquisa)
		{
			if (String.IsNullOrEmpty(pesquisa))
			{
				IEnumerable<CarreirasModel> vagas = _context.tb_carreiras;
				return View(vagas);
			}
			else
			{
				return View(_context.tb_carreiras.Where(x => x.Cargo.Contains(pesquisa)));
			}
		}
	}
}
