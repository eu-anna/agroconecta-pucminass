using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgroConecta.Migrations
{
    /// <inheritdoc />
    public partial class AjustaRelatorioImagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "Formato",
                table: "Relatorios");

            migrationBuilder.AddColumn<string>(
                name: "ImagemPath",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemPath",
                table: "Relatorios");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Relatorios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Relatorios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Formato",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
