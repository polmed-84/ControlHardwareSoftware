using System.ComponentModel.DataAnnotations;

namespace ControlHardwareSoftware.Components.Models
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }

        [Required, StringLength(100)]
        public string? nombre { get; set; }
        [StringLength(100)]
        public string? cargo { get; set; }
        [StringLength(100)]
        public string? departamento { get; set; }
        [EmailAddress, StringLength(100)]
        public string? correo { get; set; }
        [StringLength(30)]
        public string? telefono { get; set; }

        // Propiedad de navegación
        public ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
    }
}
