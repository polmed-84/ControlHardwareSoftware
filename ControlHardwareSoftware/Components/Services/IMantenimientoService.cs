
using ControlHardwareSoftware.Components.Data;
using ControlHardwareSoftware.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlHardwareSoftware.Components.Services
{
    public interface IMantenimientoService
    {
        Task<List<Mantenimiento>> ObtenerTodos();
        Task<List<Mantenimiento>> ObtenerHistorialPorEquipo(int id_equipo);
        Task<Mantenimiento?> ObtenerMantenimientoPorId(int id);
        Task<bool> GuardarMantenimiento(Mantenimiento mantenimiento);
        Task<bool> EliminarMantenimiento(int id);
    }

    public class MantenimientoService : IMantenimientoService
    {
        private readonly AppDbContext _context;
        public MantenimientoService(AppDbContext context) => _context = context;

        public async Task<List<Mantenimiento>> ObtenerTodos() =>
            await _context.Mantenimientos.Include(m => m.Equipo).ToListAsync();

        public async Task<List<Mantenimiento>> ObtenerHistorialPorEquipo(int id_equipo) =>
            await _context.Mantenimientos
                .Where(m => m.id_equipo == id_equipo)
                .OrderByDescending(m => m.fecha_mantenimiento)
                .ToListAsync();

        public async Task<Mantenimiento?> ObtenerMantenimientoPorId(int id) =>
            await _context.Mantenimientos.Include(m => m.Equipo).FirstOrDefaultAsync(m => m.id_mantenimiento == id);

        public async Task<bool> GuardarMantenimiento(Mantenimiento mantenimiento)
        {
            if (mantenimiento.id_mantenimiento > 0)
                _context.Mantenimientos.Update(mantenimiento);
            else
                _context.Mantenimientos.Add(mantenimiento);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> EliminarMantenimiento(int id)
        {
            var registro = await _context.Mantenimientos.FindAsync(id);
            if (registro == null) return false;

            _context.Mantenimientos.Remove(registro);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
