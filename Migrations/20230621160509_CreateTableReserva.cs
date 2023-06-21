using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Veiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 16, 5, 8, 727, DateTimeKind.Utc).AddTicks(2500),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatAt",
                table: "Veiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 16, 5, 8, 727, DateTimeKind.Utc).AddTicks(2887),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Estacionamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 16, 5, 8, 727, DateTimeKind.Utc).AddTicks(3899),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatAt",
                table: "Estacionamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 16, 5, 8, 727, DateTimeKind.Utc).AddTicks(4394),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstacionamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    VeiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValorTotal = table.Column<double>(type: "REAL", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    FormaPagamento = table.Column<int>(type: "INTEGER", nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    CreatAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2023, 6, 21, 16, 5, 8, 727, DateTimeKind.Utc).AddTicks(5797)),
                    UpdateAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2023, 6, 21, 16, 5, 8, 727, DateTimeKind.Utc).AddTicks(5351))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_Estacionamento_EstacionamentoId",
                        column: x => x.EstacionamentoId,
                        principalTable: "Estacionamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EstacionamentoId",
                table: "Reservas",
                column: "EstacionamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_VeiculoId",
                table: "Reservas",
                column: "VeiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Veiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7096),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 21, 16, 5, 8, 727, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatAt",
                table: "Veiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7234),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 21, 16, 5, 8, 727, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Estacionamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7628),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 21, 16, 5, 8, 727, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatAt",
                table: "Estacionamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7787),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 6, 21, 16, 5, 8, 727, DateTimeKind.Utc).AddTicks(4394));
        }
    }
}
