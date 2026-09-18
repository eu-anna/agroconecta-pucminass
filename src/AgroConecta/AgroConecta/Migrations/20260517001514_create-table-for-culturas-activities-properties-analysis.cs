using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgroConecta.Migrations
{
    public partial class createtableforculturasactivitiespropertiesanalysis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalisesCulturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CulturaId = table.Column<int>(type: "int", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recomendacoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalisesCulturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalisesCulturas_Culturas_CulturaId",
                        column: x => x.CulturaId,
                        principalTable: "Culturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtividadesAgricolas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropriedadeId = table.Column<int>(type: "int", nullable: true),
                    CulturaId = table.Column<int>(type: "int", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadesAgricolas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtividadesAgricolas_Culturas_CulturaId",
                        column: x => x.CulturaId,
                        principalTable: "Culturas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AtividadesAgricolas_Propriedades_PropriedadeId",
                        column: x => x.PropriedadeId,
                        principalTable: "Propriedades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalisesCulturas_CulturaId",
                table: "AnalisesCulturas",
                column: "CulturaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadesAgricolas_CulturaId",
                table: "AtividadesAgricolas",
                column: "CulturaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadesAgricolas_PropriedadeId",
                table: "AtividadesAgricolas",
                column: "PropriedadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalisesCulturas");

            migrationBuilder.DropTable(
                name: "AtividadesAgricolas");
        }
    }
}
