using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class RelacaoReservaEstacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstacionamentoId",
                table: "Reservas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EstacionamentoId",
                table: "Reservas",
                column: "EstacionamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Estacionamento_EstacionamentoId",
                table: "Reservas",
                column: "EstacionamentoId",
                principalTable: "Estacionamento",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Estacionamento_EstacionamentoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_EstacionamentoId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "EstacionamentoId",
                table: "Reservas");
        }
    }
}
