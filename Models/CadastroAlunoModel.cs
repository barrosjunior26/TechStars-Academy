using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TechStars_Academy.Models
{
	public class CadastroAlunoModel
	{
		[Key]
		public int Matricula { get; set; }
		[Required(ErrorMessage = "Este campo não pode ser vazio")]
		public string Nome { get; set; } = string.Empty;
		[DisplayName("Série")]
		public string Serie { get; set; } = string.Empty;
		public string Turno { get; set; } = string.Empty;
		[DisplayName("Lógica de programação")]
		public double? Logica { get; set; }
		[DisplayName("Estrutura de Dados e Algoritmos")]
		public double? Estruturas_de_Dados_e_Algoritmos { get; set; }
		[DisplayName("Programação Orientada a Objeto")]
		public double? POO { get; set; }
		[DisplayName("Banco de Dados")]
		public double? Banco_de_Dados { get; set; }
		[DisplayName("Média")]
		public double? Media { get; set; }
	}
}
