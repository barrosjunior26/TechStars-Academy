﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechStars_Academy.Data;

#nullable disable

namespace TechStars_Academy.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechStars_Academy.Models.CadastroAlunoModel", b =>
                {
                    b.Property<int>("Matricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Matricula"));

                    b.Property<double?>("Banco_de_Dados")
                        .HasColumnType("float");

                    b.Property<double?>("Estruturas_de_Dados_e_Algoritmos")
                        .HasColumnType("float");

                    b.Property<double?>("Logica")
                        .HasColumnType("float");

                    b.Property<double?>("Media")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("POO")
                        .HasColumnType("float");

                    b.Property<string>("Serie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Matricula");

                    b.ToTable("tb_cadastroAluno");
                });

            modelBuilder.Entity("TechStars_Academy.Models.CarreirasModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DataEncerramento")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DataPublicacao")
                        .HasColumnType("date");

                    b.Property<string>("InformacoesAdicionais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModoTrabalho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PCD")
                        .HasColumnType("bit");

                    b.Property<string>("RequisitoQualificacoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsabilidadeAtribuicoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_de_vaga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_carreiras");
                });
#pragma warning restore 612, 618
        }
    }
}