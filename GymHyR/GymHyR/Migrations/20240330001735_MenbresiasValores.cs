using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHyR.Migrations
{
    /// <inheritdoc />
    public partial class MenbresiasValores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "EstadoMembresias");

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "TipoMembresias",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "valor",
                table: "Membresias",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "TipoMembresias",
                keyColumn: "TipoMembresiaId",
                keyValue: 1,
                column: "Precio",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TipoMembresias",
                keyColumn: "TipoMembresiaId",
                keyValue: 2,
                column: "Precio",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TipoMembresias",
                keyColumn: "TipoMembresiaId",
                keyValue: 3,
                column: "Precio",
                value: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "TipoMembresias");

            migrationBuilder.DropColumn(
                name: "valor",
                table: "Membresias");

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
    }
}
