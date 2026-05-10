using ControlHardwareSoftware.Components.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ControlHardwareSoftware.Components.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Definición de las tablas (DbSets)
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Componente> Componentes { get; set; }
        public DbSet<Software> Softwares { get; set; }
        public DbSet<Licencia> Licencias { get; set; }
        public DbSet<SoftwareInstalado> SoftwareInstalados { get; set; }
        public DbSet<Mantenimiento> Mantenimientos { get; set; }
        public DbSet<ActualizacionSoftware> ActualizacionesSoftware { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones adicionales para nombres de tablas y relaciones si es necesario

            // Ejemplo para manejar el tipo decimal en Costo
            modelBuilder.Entity<Mantenimiento>()
                .Property(m => m.costo)
                .HasPrecision(10, 2);

            // Configuración de nombres de tablas (opcional, para asegurar coincidencia exacta)
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Ubicacion>().ToTable("Ubicacion");
            modelBuilder.Entity<Equipo>().ToTable("Equipo");
            modelBuilder.Entity<Componente>().ToTable("Componente");
            modelBuilder.Entity<Software>().ToTable("Software");
            modelBuilder.Entity<Licencia>().ToTable("Licencia");
            modelBuilder.Entity<SoftwareInstalado>().ToTable("Software_Instalado");
            modelBuilder.Entity<Mantenimiento>().ToTable("Mantenimiento");
            modelBuilder.Entity<ActualizacionSoftware>().ToTable("Actualizacion_Software");
        }
    }
}
