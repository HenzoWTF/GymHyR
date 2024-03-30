using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymHyR.Migrations
{
    /// <inheritdoc />
    public partial class Pruebas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cedula = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gmail = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cedula);
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
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    TipoMembresiaId = table.Column<int>(type: "INTEGER", nullable: false),
                    EstadoMembresiaId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFechaFin = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membresias", x => x.MembresiaId);
                    table.ForeignKey(
                        name: "FK_Membresias_Clientes_Cedula",
                        column: x => x.Cedula,
                        principalTable: "Clientes",
                        principalColumn: "Cedula");
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

            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    VisitaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MembresiaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.VisitaId);
                    table.ForeignKey(
                        name: "FK_Visitas_Clientes_Cedula",
                        column: x => x.Cedula,
                        principalTable: "Clientes",
                        principalColumn: "Cedula");
                    table.ForeignKey(
                        name: "FK_Visitas_Membresias_MembresiaId",
                        column: x => x.MembresiaId,
                        principalTable: "Membresias",
                        principalColumn: "MembresiaId");
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Cedula", "Fecha", "Gmail", "Nombre", "Telefono" },
                values: new object[] { "402-0054036-0", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Vencida", "Génerico", "Diario" });

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
                name: "IX_Membresias_Cedula",
                table: "Membresias",
                column: "Cedula");

            migrationBuilder.CreateIndex(
                name: "IX_Membresias_EstadoMembresiaId",
                table: "Membresias",
                column: "EstadoMembresiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Membresias_TipoMembresiaId",
                table: "Membresias",
                column: "TipoMembresiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_Cedula",
                table: "Visitas",
                column: "Cedula");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_MembresiaId",
                table: "Visitas",
                column: "MembresiaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitas");

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
