using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechStars_Academy.Data;
using TechStars_Academy.Models;

namespace TechStars_Academy.Controllers
{
	[Authorize(AuthenticationSchemes = "CookieAuthentication")]
	public class GestorController : Controller
	{
		private readonly ApplicationDbContext _banco;
		public GestorController(ApplicationDbContext db)
		{
			_banco = db;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Cadastro()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Cadastro(AcessoPortal acessoPortal)
		{
			if (ModelState.IsValid)
			{
				_banco.Tb_acessoPortals.Add(acessoPortal);
				await _banco.SaveChangesAsync();
				TempData["CadastroSucesso"] = "Cadastro realizado com sucesso!";
				return RedirectToAction("Cadastro");
			}

			return View(acessoPortal);
		}

		[HttpGet]
		public IActionResult Colaboradores()
		{
			List<AcessoPortal> listaColaboradores = _banco.Tb_acessoPortals.ToList();
			return View(listaColaboradores);
		}

		[HttpGet]
		public IActionResult Detalhes(int? id)
		{
			if (id == null || id < 0)
			{
				return NotFound();
			}

			AcessoPortal detalhesColaboradores = _banco.Tb_acessoPortals.FirstOrDefault(x => x.Identificacao == id);

			if (detalhesColaboradores == null)
			{
				return NotFound();
			}

			return View(detalhesColaboradores);
		}

		[HttpPost]
		public async Task<IActionResult> Detalhes(AcessoPortal atualizar)
		{
			if (ModelState.IsValid)
			{
				_banco.Tb_acessoPortals.Update(atualizar);
				await _banco.SaveChangesAsync();

				TempData["atualizar"] = "Dados atualizado com sucesso!";

				return RedirectToAction("Detalhes");
			}

			TempData["ErroAtualizar"] = "Não foi possível atualizar o dados, por favor, verifique os erros e tente novamente.";

			return View(atualizar);
		}

		[HttpGet]
		public IActionResult Excluir(int? id)
		{
			if (id == null || id < 0)
			{
				return NotFound();
			}

			AcessoPortal excluir = _banco.Tb_acessoPortals.FirstOrDefault(x => x.Identificacao == id);

			if (excluir == null)
			{
				return NotFound();
			}

			return View(excluir);
		}

		[HttpPost]
		public async Task<IActionResult> Excluir(AcessoPortal excluirCadastro)
		{
			if (excluirCadastro == null)
			{
				return NotFound();
			}

			_banco.Tb_acessoPortals.Remove(excluirCadastro);
			await _banco.SaveChangesAsync();

			TempData["ExcluirSucesso"] = "Cadastro excluído com sucesso!";

			return RedirectToAction("Colaboradores");
		}
	}
}
