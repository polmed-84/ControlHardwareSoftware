using ControlHardwareSoftware.Components.Data;
using ControlHardwareSoftware.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlHardwareSoftware.Components.Services
{
    public interface IActualizacionSoftwareService
    {
        Task<List<ActualizacionSoftware>> ObtenerHistorialPorInstalacion(int id_software_instalado);
        Task<ActualizacionSoftware?> ObtenerActualizacionPorId(int id);
        Task<bool> RegistrarActualizacion(ActualizacionSoftware actualizacion);
        Task<bool> EliminarActualizacion(int id);
    }

    public class ActualizacionSoftwareService : IActualizacionSoftwareService
    {
        private readonly AppDbContext _context;
        public ActualizacionSoftwareService(AppDbContext context) => _context = context;

        public async Task<List<ActualizacionSoftware>> ObtenerHistorialPorInstalacion(int id_software_instalado) =>
            await _context.ActualizacionesSoftware
                .Where(a => a.id_software_instalado == id_software_instalado)
                .OrderByDescending(a => a.fecha_actualizacion)
                .ToListAsync();

        public async Task<ActualizacionSoftware?> ObtenerActualizacionPorId(int id) =>
            await _context.ActualizacionesSoftware.FindAsync(id);

        public async Task<bool> RegistrarActualizacion(ActualizacionSoftware actualizacion)
        {
            if (actualizacion.id_actualizacion > 0)
                _context.ActualizacionesSoftware.Update(actualizacion);
            else
                _context.ActualizacionesSoftware.Add(actualizacion);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> EliminarActualizacion(int id)
        {
            var registro = await _context.ActualizacionesSoftware.FindAsync(id);
            if (registro == null) return false;

            _context.ActualizacionesSoftware.Remove(registro);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
