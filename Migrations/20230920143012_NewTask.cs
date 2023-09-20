using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfProject.Migrations
{
    /// <inheritdoc />
    public partial class NewTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("696473d8-38d9-47d4-9498-3a66d3717d55"),
                columns: new[] { "FechaCreacion", "FechaEntrega" },
                values: new object[] { new DateTime(2023, 9, 20, 9, 30, 12, 320, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 9, 20, 9, 30, 12, 320, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("ec4ae34e-7c21-4a42-8832-b3bbbe8ebf6b"),
                columns: new[] { "FechaCreacion", "FechaEntrega" },
                values: new object[] { new DateTime(2023, 9, 20, 9, 30, 12, 320, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 9, 20, 9, 30, 12, 320, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "FechaEntrega", "Prioridad", "Titulo" },
                values: new object[] { new Guid("37581918-83d9-4f49-bd70-a3fe6393b1e1"), new Guid("7198ea7b-115b-416b-952d-1f47bfbc0208"), "Leer en las noches", new DateTime(2023, 9, 20, 9, 30, 12, 320, DateTimeKind.Local).AddTicks(2255), new DateTime(2023, 9, 20, 9, 30, 12, 320, DateTimeKind.Local).AddTicks(2256), 2, "Leer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("37581918-83d9-4f49-bd70-a3fe6393b1e1"));

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
    }
}
