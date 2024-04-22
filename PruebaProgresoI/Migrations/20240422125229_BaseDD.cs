using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaProgresoI.Migrations
{
    /// <inheritdoc />
    public partial class BaseDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    CarreraID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCarrera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    campus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nsemestres = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.CarreraID);
                });

            migrationBuilder.CreateTable(
                name: "LCando",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaActivo = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarreraID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LCando", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LCando_Carrera_CarreraID",
                        column: x => x.CarreraID,
                        principalTable: "Carrera",
                        principalColumn: "CarreraID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LCando_CarreraID",
                table: "LCando",
                column: "CarreraID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LCando");

            migrationBuilder.DropTable(
                name: "Carrera");
        }
    }
}
