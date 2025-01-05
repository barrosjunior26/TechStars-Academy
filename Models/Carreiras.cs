using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TechStars_Academy.Models
{
	public class Carreiras
	{
		[Key, DisplayName("Código da vaga")]
		public int Codigo { get; set; }
		[Required, DisplayName("Cargo")]
		public string Cargo { get; set; } = string.Empty;
		[Required, DisplayName("Modo de trabalho")]
		public string ModoDeTrabalho { get; set; } = string.Empty;
		[Required, DisplayName("Tipo de vaga")]
		public string TipoDeVaga { get; set; } = string.Empty;
		[Required, DisplayName("Cidade")]
		public string Cidade { get; set; } = string.Empty;
		[Required, DisplayName("Estado")]
		public string Estado { get; set; } = string.Empty;
		[Required, DisplayName("Vaga também para PcD")]
		public string PCD { get; set; } = string.Empty;
		[Required, DisplayName("Data de publicação da vaga")]
		public DateOnly Publicacao { get; set; }
		[Required, DisplayName("Válidade da vaga")]
		public DateOnly Validade {  get; set; }
		[Required, DisplayName("Responsabilidades e atribuições")]
		public string ResponsabilidadeAtribuicoes { get; set; } = string.Empty;
		[Required, DisplayName("Requisitos e qualificações")]
		public string RequisitosQualificacoes { get; set; } = string.Empty;
	}
}
