using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TechStars_Academy.Models
{
	public class AcessoPortal
	{
		[Key]
		[DisplayName("Identificação")]
		public int Identificacao { get; set; }
		[Required(ErrorMessage = " * "), MaxLength(100)]
		public string Nome { get; set; } = string.Empty;
		[Required(ErrorMessage = " * ")]
		public string Cargo { get; set; } = string.Empty;
		[Required(ErrorMessage = " * ")]
		[MaxLength(11)]
		public string CPF { get; set; } = string.Empty;
		[Required, MaxLength(100), EmailAddress(ErrorMessage = "O email não é válido.")]
		public string Email { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), MaxLength(20)]
		public string Senha { get; set; } = string.Empty;
	}
}
