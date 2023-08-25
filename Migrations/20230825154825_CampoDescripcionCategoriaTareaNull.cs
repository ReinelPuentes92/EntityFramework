using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfProject.Migrations
{
    /// <inheritdoc />
    public partial class CampoDescripcionCategoriaTareaNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("696473d8-38d9-47d4-9498-3a66d3717d55"),
                columns: new[] { "FechaCreacion", "FechaEntrega" },
                values: new object[] { new DateTime(2023, 8, 25, 10, 48, 24, 918, DateTimeKind.Local).AddTicks(7805), new DateTime(2023, 8, 25, 10, 48, 24, 918, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("ec4ae34e-7c21-4a42-8832-b3bbbe8ebf6b"),
                columns: new[] { "FechaCreacion", "FechaEntrega" },
                values: new object[] { new DateTime(2023, 8, 25, 10, 48, 24, 918, DateTimeKind.Local).AddTicks(7822), new DateTime(2023, 8, 25, 10, 48, 24, 918, DateTimeKind.Local).AddTicks(7822) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("696473d8-38d9-47d4-9498-3a66d3717d55"),
                columns: new[] { "FechaCreacion", "FechaEntrega" },
                values: new object[] { new DateTime(2023, 8, 25, 10, 42, 56, 489, DateTimeKind.Local).AddTicks(6162), new DateTime(2023, 8, 25, 10, 42, 56, 489, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("ec4ae34e-7c21-4a42-8832-b3bbbe8ebf6b"),
                columns: new[] { "FechaCreacion", "FechaEntrega" },
                values: new object[] { new DateTime(2023, 8, 25, 10, 42, 56, 489, DateTimeKind.Local).AddTicks(6176), new DateTime(2023, 8, 25, 10, 42, 56, 489, DateTimeKind.Local).AddTicks(6177) });
        }
    }
}
