using EfProject.Migrations;
using EfProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EfProject.Context
{
    public class TareasContext: DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        public TareasContext(DbContextOptions<TareasContext> options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(new Categoria() {
                CategoriaId = Guid.Parse("536e8e50-70af-4f44-a9fa-3defcc6d174a"),
                Nombre = "Actividades Pendientes",
                Descripcion = "Actividades Pendientes de tarabajo",
                Peso = 30
            });

            categorias.Add(new Categoria() {
                CategoriaId = Guid.Parse("7198ea7b-115b-416b-952d-1f47bfbc0208"),
                Nombre = "Actividades Personales",
                Descripcion = "Actividades pendeintes personales",
                Peso = 50
            });

            modelBuilder.Entity<Categoria>(categoria => {
                categoria.ToTable("Categoria");
                
                categoria.HasKey(c => c.CategoriaId);

                categoria.Property(c => c.Nombre).IsRequired().HasMaxLength(150);

                categoria.Property(c => c.Descripcion).IsRequired(false).HasMaxLength(250);

                categoria.Property(c => c.Peso);

                categoria.HasData(categorias);
            });

            List<Tarea> tareas = new List<Tarea>();

            tareas.Add(new Tarea () {
                TareaId = Guid.Parse("696473d8-38d9-47d4-9498-3a66d3717d55"),
                CategoriaId = Guid.Parse("536e8e50-70af-4f44-a9fa-3defcc6d174a"),
                Titulo = "Programacion",
                Descripcion = "Terminar actualizacion masiva ECOTIC",
                Prioridad = Prioridad.Media,
                FechaCreacion = DateTime.Now,
                FechaEntrega = DateTime.Now
            });

            tareas.Add(new Tarea () {
                TareaId = Guid.Parse("ec4ae34e-7c21-4a42-8832-b3bbbe8ebf6b"),
                CategoriaId = Guid.Parse("7198ea7b-115b-416b-952d-1f47bfbc0208"),
                Titulo = "Ejercicio",
                Descripcion = "Hacer Ejercicio 3 veces a la semana",
                Prioridad = Prioridad.Media,
                FechaCreacion = DateTime.Now,
                FechaEntrega = DateTime.Now
            });

            modelBuilder.Entity<Tarea>(tarea => {
                tarea.ToTable("Tarea");

                tarea.HasKey(t => t.TareaId);

                tarea.HasOne(t => t.Categoria).WithMany(t => t.Tareas).HasForeignKey(t => t.CategoriaId);

                tarea.Property(t => t.Titulo).IsRequired().HasMaxLength(200);

                tarea.Property(t => t.Descripcion).IsRequired(false).HasMaxLength(255);

                tarea.Property(t => t.Prioridad).HasMaxLength(20);

                tarea.Property(t => t.FechaCreacion);

                tarea.Property(t => t.FechaEntrega);

                tarea.Ignore(t => t.Resumen);

                tarea.HasData(tareas);
            });
        }
    }
}