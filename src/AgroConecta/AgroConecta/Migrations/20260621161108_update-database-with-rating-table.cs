using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgroConecta.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabasewithratingtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtividadesAgricolas_Propriedades_PropriedadeId",
                table: "AtividadesAgricolas");

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Classificacao = table.Column<int>(type: "int", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditadoEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_PedidoId",
                table: "Avaliacoes",
                column: "PedidoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AtividadesAgricolas_Propriedades_PropriedadeId",
                table: "AtividadesAgricolas",
                column: "PropriedadeId",
                principalTable: "Propriedades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtividadesAgricolas_Propriedades_PropriedadeId",
                table: "AtividadesAgricolas");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.AddForeignKey(
                name: "FK_AtividadesAgricolas_Propriedades_PropriedadeId",
                table: "AtividadesAgricolas",
                column: "PropriedadeId",
                principalTable: "Propriedades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
