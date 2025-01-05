using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TechStars_Academy.Data;
using TechStars_Academy.Models;

namespace TechStars_Academy.Controllers
{
	public class LoginController : Controller
	{
		private readonly ApplicationDbContext _banco;
		public LoginController(ApplicationDbContext db)
		{
			_banco = db;
		}

		[HttpGet]
		public IActionResult Entrar()
		{
			ClaimsPrincipal identificacao = HttpContext.User;
			if (identificacao.Identity.IsAuthenticated)
			{
				return Redirect("/Gestor/Index");
			}

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Entrar(string email, string senha)
		{
			AcessoPortal acessoPortal = _banco.Tb_acessoPortals.Where(x => x.Email == email && x.Senha == senha).FirstOrDefault();

			if (acessoPortal == null)
			{
				TempData["FalhaLogin"] = "Login ou senha está incorreto, por favor, tente novamente.";
				return View();
			}

			var claims = new List<Claim>();
			claims.Add(new Claim(ClaimTypes.Name, acessoPortal.Email));
			claims.Add(new Claim(ClaimTypes.Sid, acessoPortal.Identificacao.ToString()));
			
			var identidadeUsuario = new ClaimsIdentity(claims, "Acesso");

			ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identidadeUsuario);
			await HttpContext.SignInAsync("CookieAuthentication", claimsPrincipal, new AuthenticationProperties());

			return Redirect("/Gestor/Index");
		}

		public async Task<IActionResult> Sair()
		{
			await HttpContext.SignOutAsync();
			return Redirect("/Login/Entrar");
		}
	}
}
