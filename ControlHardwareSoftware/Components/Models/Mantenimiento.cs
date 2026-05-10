using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlHardwareSoftware.Components.Models
{
 
    public class Mantenimiento
    {
        [Key]
        public int id_mantenimiento { get; set; }

        public int? id_equipo { get; set; }

        [ForeignKey("id_equipo")]
        public Equipo? Equipo { get; set; }

        [StringLength(50)]
        public string? tipo_mantenimiento { get; set; }

        [StringLength(300)]
        public string? descripcion_problema { get; set; }

        [StringLength(300)]
        public string? solucion { get; set; }

        [StringLength(100)]
        public string? tecnico { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? costo { get; set; }

        public DateTime? fecha_mantenimiento { get; set; }

        [StringLength(50)]
        public string? estado { get; set; }
    }
}
