using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlHardwareSoftware.Components.Models
{
    
    public class ActualizacionSoftware
    {
        [Key]
        public int id_actualizacion { get; set; }

        public int? id_software_instalado { get; set; }

        [ForeignKey("id_software_instalado")]
        public SoftwareInstalado? SoftwareInstalado { get; set; }

        [StringLength(50)]
        public string? version_anterior { get; set; }

        [StringLength(50)]
        public string? version_nueva { get; set; }

        public DateTime? fecha_actualizacion { get; set; }

        [StringLength(100)]
        public string? responsable { get; set; }

        [StringLength(300)]
        public string? observaciones { get; set; }
    }
}
