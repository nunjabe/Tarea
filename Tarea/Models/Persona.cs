using System.ComponentModel.DataAnnotations;

namespace Tarea.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "# Cuenta es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "# Cuenta debe ser mayor que 0.")]
        public int? Num_cuenta { get; set; }

        [Required(ErrorMessage = "Nombre no debe ser vacío.")]
        [MaxLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Correo no debe ser vacío.")]
        [EmailAddress(ErrorMessage = "Correo debe ser un correo válido.")]
        public string? Correo { get; set; }

        [Range(0, 10, ErrorMessage = "Calificación debe estar entre 0 y 10.")]
        public int? Calificacion { get; set; }
    }
}
