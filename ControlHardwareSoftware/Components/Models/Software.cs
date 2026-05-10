using System.ComponentModel.DataAnnotations;

namespace ControlHardwareSoftware.Components.Models
{
   
    public class Software
    {
        [Key]
        public int id_software { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string? nombre { get; set; }

        [StringLength(50)]
        public string? version_actual { get; set; }

        [StringLength(50)]
        public string? tipo_software { get; set; }

        [StringLength(100)]
        public string? fabricante { get; set; }

        // Propiedades de navegación
        public ICollection<Licencia> Licencias { get; set; } = new List<Licencia>();
        public ICollection<SoftwareInstalado> SoftwaresInstalados { get; set; } = new List<SoftwareInstalado>();
    }
}
