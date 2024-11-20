using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TechStars_Academy.Models
{
	public class CarreirasModel
	{
		[Key]
		[DisplayName("Código da vaga")]
		public int Id { get; set; }
		[Required(ErrorMessage = "Este campo deve ser preenchido!")]
		public string Cargo { get; set; } = string.Empty;
		[DisplayName("Data de publicação da vaga"), Required(ErrorMessage = "Este campo deve ser preenchido!")]
		public DateOnly DataPublicacao { get; set; }
		[DisplayName("Data que se encerra a vaga")]
		public DateOnly DataEncerramento { get; set; }
		[DisplayName("Local de trabalho"), Required(ErrorMessage = "Este campo deve ser preenchido!")]
		public string Localizacao { get; set; } = string.Empty;
		[DisplayName("Modo de trabalho"), Required(ErrorMessage = "Este campo deve ser preenchido!")]
		public string ModoTrabalho { get; set; } = string.Empty;
		[DisplayName("Vaga também para PcD"), Required(ErrorMessage = "Este campo deve ser preenchido!")]
		public bool PCD { get; set; } = false;
		[DisplayName("Responsabilidades e atribuições"), Required(ErrorMessage = "Este campo deve ser preenchido!")]
		public string ResponsabilidadeAtribuicoes { get; set; } = string.Empty;
		[DisplayName("Requisitos e qualificações"), Required(ErrorMessage = "Este campo deve ser preenchido!")]
		public string RequisitoQualificacoes { get; set; } = string.Empty;
		[DisplayName("Informações adicionais"), Required(ErrorMessage = "Este campo deve ser preenchido!")]
		public string InformacoesAdicionais { get; set; } = string.Empty;
		[DisplayName("Tipo de vaga"), Required(ErrorMessage = "Este campo deve ser preenchido!")]
		public string Tipo_de_vaga { get; set; } = string.Empty;
	}
}
