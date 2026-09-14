using System.ComponentModel.DataAnnotations;

namespace registro_estudiantes.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        [StringLength(150)]
        public string Apellidos { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La matrícula es obligatoria")]
        [StringLength(20)]
        public string Matricula { get; set; } = string.Empty;

        public bool Estado { get; set; } = true; // true = activo, false = inactivo

        // Navegación
        public ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
    }
}
