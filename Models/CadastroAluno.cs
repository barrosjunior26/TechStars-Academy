using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TechStars_Academy.Models
{
	public class CadastroAluno
	{
		//Dados pessoais do aluno
		[Key]
		public int Matricula { get; set; }
		[Required(ErrorMessage = " * "), DisplayName("Nome")]
		public string Nome { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), DisplayName("Nascimento")]
		public string Nascimento { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), DisplayName("RG"), MaxLength(7)]
		public string RG { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), DisplayName("CPF"), MaxLength(11)]
		public string CPF { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), DisplayName("Sexo")]
		public string Sexo { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), DisplayName("Responsável")]
		public string Responsavel { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), DisplayName("CPF do responsável"), MaxLength(11)]
		public string CPF_Responsavel { get; set; } = string.Empty;


		//Dados do curso
		[Required(ErrorMessage = " * "), DisplayName("Curso")]
		public string Curso { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), DisplayName("Ano")]
		public string Ano { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), DisplayName("Turno")]
		public string Turno { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), DisplayName("Contrato")]
		public string Contrato { get; set; } = string.Empty;
		[Required(ErrorMessage = " * "), DisplayName("Data da matrícula")]
		public DateTime DataMatricula { get; set; } = DateTime.Now;

		//Informações sobre notas
		[DisplayName("Fundamentos de Computação")]
		public double? FundamentosDeComputacao { get; set; }
		[DisplayName("Desenvolvimento de Software")]
		public double? DesenvolvimentoDeSoftware { get; set; }
		[DisplayName("Infraestrutura e Sistemas Operacionais")]
		public double? Infraestrutura_e_Sistemas_Operacionais { get; set; }
		[DisplayName("Tecnologias e Ferramentas")]
		public double? Tecnologias_e_Ferramentas { get; set; }
		[DisplayName("Matemática e Estatística")]
		public double? Matematica_e_Estatistica { get; set; }
		[DisplayName("Soft Skills e Gestão")]
		public double? Soft_Skills_e_Gestao { get; set; }
		[DisplayName("Média geral do aluno")]
		public double? MediaGeral { get; set; }
	}
}
