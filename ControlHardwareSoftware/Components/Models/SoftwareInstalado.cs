using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlHardwareSoftware.Components.Models
{
  
    public class SoftwareInstalado
    {
        [Key]
        public int id_software_instalado { get; set; }

        public int? id_equipo { get; set; }
        [ForeignKey("id_equipo")]
        public Equipo? Equipo { get; set; }

        public int? id_software { get; set; }
        [ForeignKey("id_software")]
        public Software? Software { get; set; }

        public int? id_licencia { get; set; }
        [ForeignKey("id_licencia")]
        public Licencia? Licencia { get; set; }

        [StringLength(50)]
        public string? version_instalada { get; set; }

        public DateTime? fecha_instalacion { get; set; }

        [StringLength(50)]
        public string? estado { get; set; }

        public bool requiere_actualizacion { get; set; } = false;


        // Relación con Actualizacion_Software
        public ICollection<ActualizacionSoftware> Actualizaciones { get; set; } = new List<ActualizacionSoftware>();
    }
}
