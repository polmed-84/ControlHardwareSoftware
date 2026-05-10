using ControlHardwareSoftware.Components.Data;
using ControlHardwareSoftware.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlHardwareSoftware.Components.Services
{
    public interface ILicenciaService
    {
        Task<List<Licencia>> ObtenerLicencias();
        Task<Licencia?> ObtenerLicenciaPorId(int id);
        Task<bool> GuardarLicencia(Licencia licencia);
        Task<bool> EliminarLicencia(int id);
    }

    public class LicenciaService : ILicenciaService
    {
        private readonly AppDbContext _context;
        public LicenciaService(AppDbContext context) => _context = context;

        public async Task<List<Licencia>> ObtenerLicencias() =>
            await _context.Licencias.Include(l => l.Software).ToListAsync();

        public async Task<Licencia?> ObtenerLicenciaPorId(int id) =>
            await _context.Licencias.FindAsync(id);

        public async Task<bool> GuardarLicencia(Licencia licencia)
        {
            if (licencia.id_licencia > 0) _context.Licencias.Update(licencia);
            else _context.Licencias.Add(licencia);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> EliminarLicencia(int id)
        {
            var licencia = await _context.Licencias.FindAsync(id);
            if (licencia == null) return false;
            _context.Licencias.Remove(licencia);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
