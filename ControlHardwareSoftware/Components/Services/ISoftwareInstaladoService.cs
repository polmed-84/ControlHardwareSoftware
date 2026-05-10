using ControlHardwareSoftware.Components.Data;
using ControlHardwareSoftware.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlHardwareSoftware.Components.Services
{
    public interface ISoftwareInstaladoService
    {
        Task<List<SoftwareInstalado>> ObtenerInstalaciones();
        Task<SoftwareInstalado?> ObtenerInstalacionPorId(int id);
        Task<List<SoftwareInstalado>> ObtenerInstalacionesPorEquipo(int id_equipo);
        Task<bool> GuardarInstalacion(SoftwareInstalado instalacion);
        Task<bool> EliminarInstalacion(int id);
    }

    public class SoftwareInstaladoService : ISoftwareInstaladoService
    {
        private readonly AppDbContext _context;
        public SoftwareInstaladoService(AppDbContext context) => _context = context;

        public async Task<List<SoftwareInstalado>> ObtenerInstalaciones() =>
            await _context.SoftwareInstalados
                .Include(s => s.Equipo)
                .Include(s => s.Software)
                .Include(s => s.Licencia)
                .ToListAsync();

        public async Task<SoftwareInstalado?> ObtenerInstalacionPorId(int id) =>
            await _context.SoftwareInstalados
                .Include(s => s.Equipo)
                .Include(s => s.Software)
                .Include(s => s.Licencia)
                .Include(s => s.Actualizaciones) // Incluye el historial de actualizaciones
                .FirstOrDefaultAsync(s => s.id_software_instalado == id);

        public async Task<List<SoftwareInstalado>> ObtenerInstalacionesPorEquipo(int id_equipo) =>
            await _context.SoftwareInstalados
                .Include(s => s.Software)
                .Include(s => s.Licencia)
                .Where(s => s.id_equipo == id_equipo)
                .ToListAsync();

        public async Task<bool> GuardarInstalacion(SoftwareInstalado instalacion)
        {
            if (instalacion.id_software_instalado > 0)
                _context.SoftwareInstalados.Update(instalacion);
            else
                _context.SoftwareInstalados.Add(instalacion);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> EliminarInstalacion(int id)
        {
            var registro = await _context.SoftwareInstalados.FindAsync(id);
            if (registro == null) return false;

            _context.SoftwareInstalados.Remove(registro);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
