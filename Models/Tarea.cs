using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfProject.Models
{
    public class Tarea
    {
        [Key]
        public Guid TareaId { get; set; }

        [ForeignKey("Categoria_CategoriaId")]
        public Guid CategoriaId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Titulo { get; set; }

        [MaxLength(255)]
        public string Descripcion { get; set; }

        public Prioridad Prioridad { get; set; }

        public DateTime FechaCreacion { get; set; }

        public virtual Categoria Categoria { get; set; }
        
        [NotMapped]
        public string Resumen { get; set; }
    }

    public enum Prioridad 
    {
        Alta,
        Media,
        Baja
    }
}