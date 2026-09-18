using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgroConecta.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabasepurchasetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeCliente",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeCliente",
                table: "Pedidos");
        }
    }
}
