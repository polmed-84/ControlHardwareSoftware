using ControlHardwareSoftware.Components.Data;
using ControlHardwareSoftware.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlHardwareSoftware.Components.Services
{
    public interface ISoftwareService
    {
        Task<List<Software>> ObtenerSoftwares();
        Task<Software?> ObtenerSoftwarePorId(int id);
        Task<List<SoftwareInstalado>> ObtenerSoftwarePorEquipo(int id_equipo);
        Task<bool> RegistrarInstalacion(SoftwareInstalado instalacion);
        Task<bool> GuardarSoftware(Software software);
        Task<bool> EliminarSoftware(int id);
    }

    public class SoftwareService : ISoftwareService
    {
        private readonly AppDbContext _context;
        public SoftwareService(AppDbContext context) => _context = context;

        public async Task<List<Software>> ObtenerSoftwares() =>
            await _context.Softwares.ToListAsync();

        public async Task<Software?> ObtenerSoftwarePorId(int id) =>
            await _context.Softwares.FindAsync(id);

        public async Task<List<SoftwareInstalado>> ObtenerSoftwarePorEquipo(int id_equipo) =>
            await _context.SoftwareInstalados
                .Include(s => s.Software)
                .Include(s => s.Licencia)
                .Where(s => s.id_equipo == id_equipo).ToListAsync();

        public async Task<bool> RegistrarInstalacion(SoftwareInstalado instalacion)
        {
            _context.SoftwareInstalados.Add(instalacion);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> GuardarSoftware(Software software)
        {
            if (software.id_software > 0)
                _context.Softwares.Update(software);
            else
                _context.Softwares.Add(software);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> EliminarSoftware(int id)
        {
            var software = await _context.Softwares.FindAsync(id);
            if (software == null) return false;

            _context.Softwares.Remove(software);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
