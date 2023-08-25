using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EfProject.Migrations
{
    /// <inheritdoc />
    public partial class DataCataegoria_DataTareas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("536e8e50-70af-4f44-a9fa-3defcc6d174a"), "Actividades Pendientes de tarabajo", "Actividades Pendientes", 30 },
                    { new Guid("7198ea7b-115b-416b-952d-1f47bfbc0208"), "Actividades pendeintes personales", "Actividades Personales", 50 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "FechaEntrega", "Prioridad", "Titulo" },
                values: new object[,]
                {
                    { new Guid("696473d8-38d9-47d4-9498-3a66d3717d55"), new Guid("536e8e50-70af-4f44-a9fa-3defcc6d174a"), "Terminar actualizacion masiva ECOTIC", new DateTime(2023, 8, 25, 10, 42, 56, 489, DateTimeKind.Local).AddTicks(6162), new DateTime(2023, 8, 25, 10, 42, 56, 489, DateTimeKind.Local).AddTicks(6172), 1, "Programacion" },
                    { new Guid("ec4ae34e-7c21-4a42-8832-b3bbbe8ebf6b"), new Guid("7198ea7b-115b-416b-952d-1f47bfbc0208"), "Hacer Ejercicio 3 veces a la semana", new DateTime(2023, 8, 25, 10, 42, 56, 489, DateTimeKind.Local).AddTicks(6176), new DateTime(2023, 8, 25, 10, 42, 56, 489, DateTimeKind.Local).AddTicks(6177), 1, "Ejercicio" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("696473d8-38d9-47d4-9498-3a66d3717d55"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("ec4ae34e-7c21-4a42-8832-b3bbbe8ebf6b"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("536e8e50-70af-4f44-a9fa-3defcc6d174a"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("7198ea7b-115b-416b-952d-1f47bfbc0208"));
        }
    }
}
