using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStars_Academy.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_acessoPortals",
                columns: table => new
                {
                    Identificacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_acessoPortals", x => x.Identificacao);
                });

            migrationBuilder.CreateTable(
                name: "Tb_cadastroAlunos",
                columns: table => new
                {
                    Matricula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsavel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF_Responsavel = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ano = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataMatricula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FundamentosDeComputacao = table.Column<double>(type: "float", nullable: true),
                    DesenvolvimentoDeSoftware = table.Column<double>(type: "float", nullable: true),
                    Infraestrutura_e_Sistemas_Operacionais = table.Column<double>(type: "float", nullable: true),
                    Tecnologias_e_Ferramentas = table.Column<double>(type: "float", nullable: true),
                    Matematica_e_Estatistica = table.Column<double>(type: "float", nullable: true),
                    Soft_Skills_e_Gestao = table.Column<double>(type: "float", nullable: true),
                    MediaGeral = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_cadastroAlunos", x => x.Matricula);
                });

            migrationBuilder.CreateTable(
                name: "Tb_carreiras",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModoDeTrabalho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDeVaga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PCD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publicacao = table.Column<DateOnly>(type: "date", nullable: false),
                    Validade = table.Column<DateOnly>(type: "date", nullable: false),
                    ResponsabilidadeAtribuicoes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequisitosQualificacoes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_carreiras", x => x.Codigo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_acessoPortals");

            migrationBuilder.DropTable(
                name: "Tb_cadastroAlunos");

            migrationBuilder.DropTable(
                name: "Tb_carreiras");
        }
    }
}
