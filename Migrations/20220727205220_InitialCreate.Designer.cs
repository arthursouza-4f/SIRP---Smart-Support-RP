﻿// <auto-generated />
using System;
using EstacionamentoBenner.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asm.Migrations
{
    [DbContext(typeof(WebAppDbContext))]
    [Migration("20220727205220_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Asm.Models.BaseDB.BauItens", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CodigoDaAlteracao")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracaoBau")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeItem")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Bau", (string)null);
                });

            modelBuilder.Entity("Asm.Models.BaseDB.ContratadosModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AtivoInativo")
                        .HasColumnType("int");

                    b.Property<int>("CodigoEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contratados", (string)null);
                });

            modelBuilder.Entity("Asm.Models.BaseDB.EmpresasModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CodigoEmpresa")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDaCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmpresaAtivaInativa")
                        .HasColumnType("int");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Empresas", (string)null);
                });

            modelBuilder.Entity("Asm.Models.BaseDB.VendasModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DataDaVenda")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecoVendido")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QuantidadeVendida")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Vendas", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
