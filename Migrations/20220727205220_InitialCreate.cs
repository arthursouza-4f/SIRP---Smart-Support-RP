using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asm.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bau",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadeItem = table.Column<int>(type: "int", nullable: false),
                    DataAlteracaoBau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoDaAlteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bau", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contratados",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoEmpresa = table.Column<int>(type: "int", nullable: false),
                    AtivoInativo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratados", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoEmpresa = table.Column<int>(type: "int", nullable: false),
                    EmpresaAtivaInativa = table.Column<int>(type: "int", nullable: false),
                    DataDaCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadeVendida = table.Column<int>(type: "int", nullable: false),
                    PrecoVendido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataDaVenda = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bau");

            migrationBuilder.DropTable(
                name: "Contratados");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
