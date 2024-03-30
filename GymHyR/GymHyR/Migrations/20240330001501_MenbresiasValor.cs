using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHyR.Migrations
{
    /// <inheritdoc />
    public partial class MenbresiasValor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Valor",
                table: "EstadoMembresias",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EstadoMembresias",
                keyColumn: "EstadoMembresiaId",
                keyValue: 1,
                column: "Valor",
                value: null);

            migrationBuilder.UpdateData(
                table: "EstadoMembresias",
                keyColumn: "EstadoMembresiaId",
                keyValue: 2,
                column: "Valor",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "EstadoMembresias");
        }
    }
}
