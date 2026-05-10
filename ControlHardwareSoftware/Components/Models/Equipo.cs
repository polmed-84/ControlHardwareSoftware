using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlHardwareSoftware.Components.Models
{
  
    public class Equipo
    {
        [Key]
        public int id_equipo { get; set; }

        [StringLength(50)]
        public string? codigo_inventario { get; set; }

        [StringLength(50)]
        public string? tipo_equipo { get; set; }

        [StringLength(50)]
        public string? marca { get; set; }

        [StringLength(50)]
        public string? modelo { get; set; }

        [StringLength(100)]
        public string? numero_serie { get; set; }

        public DateTime? fecha_compra { get; set; }

        [StringLength(50)]
        public string? estado { get; set; }

        // Relación con Usuario
        public int? id_usuario { get; set; }
        [ForeignKey("id_usuario")]
        public Usuario? Usuario { get; set; }

        // Relación con Ubicacion
        public int? id_ubicacion { get; set; }
        [ForeignKey("id_ubicacion")]
        public Ubicacion? Ubicacion { get; set; }

        // Propiedades de navegación para relaciones inversas
        public ICollection<Componente> Componentes { get; set; } = new List<Componente>();
        public ICollection<SoftwareInstalado> SoftwaresInstalados { get; set; } = new List<SoftwareInstalado>();
        public ICollection<Mantenimiento> Mantenimientos { get; set; } = new List<Mantenimiento>();
    }
}
