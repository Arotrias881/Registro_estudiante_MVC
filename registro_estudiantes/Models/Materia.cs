using System.ComponentModel.DataAnnotations;

namespace registro_estudiantes.Models
{
    public class Materia
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la materia es obligatorio")]
        [StringLength(150)]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El código es obligatorio")]
        [StringLength(20)]
        public string Codigo { get; set; } = string.Empty;

        [Range(1, 10)]
        public int Creditos { get; set; }

        [StringLength(500)]
        public string? Descripcion { get; set; }

        public bool Estado { get; set; } = true; 

        // Navegación
        public ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
    }
}
