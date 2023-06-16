using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estacionamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Capacidade = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorHora = table.Column<double>(type: "REAL", nullable: false),
                    ValorTaxaIncial = table.Column<double>(type: "REAL", nullable: false),
                    TempoPadrao = table.Column<int>(type: "INTEGER", nullable: false),
                    TempoTolerancia = table.Column<int>(type: "INTEGER", nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    CreatAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2023, 6, 16, 16, 52, 23, 228, DateTimeKind.Utc).AddTicks(1496)),
                    UpdateAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2023, 6, 16, 16, 52, 23, 228, DateTimeKind.Utc).AddTicks(1033))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estacionamento", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estacionamento");
        }
    }
}
