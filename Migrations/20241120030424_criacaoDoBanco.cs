using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStars_Academy.Migrations
{
    /// <inheritdoc />
    public partial class criacaoDoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_cadastroAluno",
                columns: table => new
                {
                    Matricula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logica = table.Column<double>(type: "float", nullable: true),
                    Estruturas_de_Dados_e_Algoritmos = table.Column<double>(type: "float", nullable: true),
                    POO = table.Column<double>(type: "float", nullable: true),
                    Banco_de_Dados = table.Column<double>(type: "float", nullable: true),
                    Media = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cadastroAluno", x => x.Matricula);
                });

            migrationBuilder.CreateTable(
                name: "tb_carreiras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataPublicacao = table.Column<DateOnly>(type: "date", nullable: false),
                    DataEncerramento = table.Column<DateOnly>(type: "date", nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModoTrabalho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PCD = table.Column<bool>(type: "bit", nullable: false),
                    ResponsabilidadeAtribuicoes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequisitoQualificacoes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacoesAdicionais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_de_vaga = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_carreiras", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_cadastroAluno");

            migrationBuilder.DropTable(
                name: "tb_carreiras");
        }
    }
}
