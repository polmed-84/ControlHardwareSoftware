using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlHardwareSoftware.Components.Models
{
    public class Licencia
    {
        [Key]
        public int id_licencia { get; set; }

        public int? id_software { get; set; }
        [ForeignKey("id_software")]
        public Software? Software { get; set; }

        [StringLength(50)]
        public string? tipo_licencia { get; set; }

        [StringLength(100)]
        public string? clave_licencia { get; set; }

        public int? cantidad_licencias { get; set; }

        public DateTime? fecha_compra { get; set; }

        public DateTime? fecha_vencimiento { get; set; }

        [StringLength(100)]
        public string? proveedor { get; set; }

        [StringLength(50)]
        public string? estado { get; set; }
    }
}
