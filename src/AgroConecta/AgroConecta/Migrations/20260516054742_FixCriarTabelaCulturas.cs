using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgroConecta.Migrations
{
    public partial class FixCriarTabelaCulturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Culturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCultura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaPlantio = table.Column<double>(type: "float", nullable: false),
                    DataPlantio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPrevistaColheita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataIrrigacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropriedadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Culturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Culturas_Propriedades_PropriedadeId",
                        column: x => x.PropriedadeId,
                        principalTable: "Propriedades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Culturas_PropriedadeId",
                table: "Culturas",
                column: "PropriedadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Culturas");
        }
    }
}
