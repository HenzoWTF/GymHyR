using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymHyR.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: false),
                    Gmail = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "EstadoMembresias",
                columns: table => new
                {
                    EstadoMembresiaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoMembresias", x => x.EstadoMembresiaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoMembresias",
                columns: table => new
                {
                    TipoMembresiaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    DiasDuracion = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMembresias", x => x.TipoMembresiaId);
                });

            migrationBuilder.CreateTable(
                name: "Membresias",
                columns: table => new
                {
                    MembresiaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoMembresiaId = table.Column<int>(type: "INTEGER", nullable: false),
                    EstadoMembresiaId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFechaFin = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membresias", x => x.MembresiaId);
                    table.ForeignKey(
                        name: "FK_Membresias_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Membresias_EstadoMembresias_EstadoMembresiaId",
                        column: x => x.EstadoMembresiaId,
                        principalTable: "EstadoMembresias",
                        principalColumn: "EstadoMembresiaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Membresias_TipoMembresias_TipoMembresiaId",
                        column: x => x.TipoMembresiaId,
                        principalTable: "TipoMembresias",
                        principalColumn: "TipoMembresiaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Cedula", "Fecha", "Gmail", "Nombre", "Telefono" },
                values: new object[] { 1, "123", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Vencida", "Génerico", "Diario" });

            migrationBuilder.InsertData(
                table: "EstadoMembresias",
                columns: new[] { "EstadoMembresiaId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Activa" },
                    { 2, "Vencida" }
                });

            migrationBuilder.InsertData(
                table: "TipoMembresias",
                columns: new[] { "TipoMembresiaId", "Descripcion", "DiasDuracion" },
                values: new object[,]
                {
                    { 1, "Mensual", 30 },
                    { 2, "Semanal", 5 },
                    { 3, "Diario", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Membresias_ClienteId",
                table: "Membresias",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Membresias_EstadoMembresiaId",
                table: "Membresias",
                column: "EstadoMembresiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Membresias_TipoMembresiaId",
                table: "Membresias",
                column: "TipoMembresiaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Membresias");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "EstadoMembresias");

            migrationBuilder.DropTable(
                name: "TipoMembresias");
        }
    }
}
