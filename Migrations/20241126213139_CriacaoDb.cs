using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVeiculos.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoDiario",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "QuantidadeDisponivel",
                table: "Carros");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoDiario",
                table: "Reservas",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "Carros",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Carros",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoDiario",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "Placa",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Carros");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoDiario",
                table: "Carros",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeDisponivel",
                table: "Carros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
