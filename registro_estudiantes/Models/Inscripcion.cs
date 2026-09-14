using System.ComponentModel.DataAnnotations;

namespace registro_estudiantes.Models
{
    public enum EstadoInscripcion
    {
        Activa,
        Completada,
        Cancelada
    }

    public class Inscripcion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El estudiante es obligatorio")]
        public int EstudianteId { get; set; }

        [Required(ErrorMessage = "La materia es obligatoria")]
        public int MateriaId { get; set; }

        [Required(ErrorMessage = "La fecha de inscripción es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime FechaInscripcion { get; set; } = DateTime.Now;

        [Required]
        public EstadoInscripcion Estado { get; set; } = EstadoInscripcion.Activa;

        [Range(0, 10)]
        public decimal? Nota { get; set; }

        // Navegación
        public Estudiante? Estudiante { get; set; }
        public Materia? Materia { get; set; }
    }
}
