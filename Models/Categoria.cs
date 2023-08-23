using System.ComponentModel.DataAnnotations;

namespace EfProject.Models
{
    public class Categoria
    {
        [Key]
        public Guid CategoriaId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }

        [MaxLength(255)]
        public string Descripcion { get; set; }
        
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}