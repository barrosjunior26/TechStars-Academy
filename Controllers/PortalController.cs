using Microsoft.AspNetCore.Mvc;

namespace TechStars_Academy.Controllers
{
	public class PortalController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult CadastroAluno()
		{
			return View();
		}
	}
}
