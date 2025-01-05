using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TechStars_Academy.Controllers
{
	[Authorize(AuthenticationSchemes = "CookieAuthentication")]
	public class AlunoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Cadastro()
		{
			return View();
		}
	}
}
