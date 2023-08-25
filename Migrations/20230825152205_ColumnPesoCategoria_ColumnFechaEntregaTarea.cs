using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfProject.Migrations
{
    /// <inheritdoc />
    public partial class ColumnPesoCategoria_ColumnFechaEntregaTarea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEntrega",
                table: "Tarea",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Peso",
                table: "Categoria",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaEntrega",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Categoria");
        }
    }
}
