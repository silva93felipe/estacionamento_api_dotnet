using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class IncluirVeiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorTaxaIncial",
                table: "Estacionamento",
                newName: "ValorTaxaInicial");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Estacionamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7628),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 16, 16, 52, 23, 228, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatAt",
                table: "Estacionamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7787),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 16, 16, 52, 23, 228, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Placa = table.Column<string>(type: "VARCHAR", maxLength: 7, nullable: false),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 1),
                    NomeProprietario = table.Column<string>(type: "VARCHAR", maxLength: 30, nullable: false),
                    DocumentoProprietario = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    CreatAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7234)),
                    UpdateAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7096))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.RenameColumn(
                name: "ValorTaxaInicial",
                table: "Estacionamento",
                newName: "ValorTaxaIncial");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Estacionamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 16, 52, 23, 228, DateTimeKind.Utc).AddTicks(1033),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatAt",
                table: "Estacionamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 16, 52, 23, 228, DateTimeKind.Utc).AddTicks(1496),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7787));
        }
    }
}
