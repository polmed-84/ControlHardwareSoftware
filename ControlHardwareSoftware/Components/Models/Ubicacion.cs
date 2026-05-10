
using System.ComponentModel.DataAnnotations;

namespace ControlHardwareSoftware.Components.Models
{
    public class Ubicacion
    {
        [Key]
        public int id_ubicacion { get; set; }

        public string? nombre_area { get; set; }
        public string? direccion { get; set; }
        public string? descripcion { get; set; }

        // Propiedad de navegación: Una ubicación tiene muchos equipos
        public ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
    }
}
