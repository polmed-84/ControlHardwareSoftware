using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlHardwareSoftware.Components.Models
{
    
    public class Componente
    {
        [Key]
        public int id_componente { get; set; }

        public int? id_equipo { get; set; }

        [ForeignKey("id_equipo")]
        public Equipo? Equipo { get; set; }

        public string? tipo_componente { get; set; }
        public string? descripcion { get; set; }
        public string? marca { get; set; }
        public string? modelo { get; set; }
        public string? capacidad { get; set; }
    }
}
