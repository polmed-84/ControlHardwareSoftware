using ControlHardwareSoftware.Components.Data;
using ControlHardwareSoftware.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlHardwareSoftware.Components.Services
{
    public interface IUbicacionService
    {
        Task<List<Ubicacion>> ObtenerUbicaciones();
        Task<List<Ubicacion>> ObtenerUbicacionesEquipos();
        Task<Ubicacion?> ObtenerUbicacionPorId(int id);
        Task<bool> GuardarUbicacion(Ubicacion ubicacion);
        Task<bool> EliminarUbicacion(int id);
    }

    public class UbicacionService : IUbicacionService
    {
        private readonly AppDbContext _context;

        public UbicacionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ubicacion>> ObtenerUbicaciones()
        {
            return await _context.Ubicaciones.ToListAsync();
        }

        public async Task<List<Ubicacion>> ObtenerUbicacionesEquipos()
        {
            return await _context.Ubicaciones.Include(s=>s.Equipos).ToListAsync();
        }

        public async Task<Ubicacion?> ObtenerUbicacionPorId(int id)
        {
            return await _context.Ubicaciones.FindAsync(id);
        }

        public async Task<bool> GuardarUbicacion(Ubicacion ubicacion)
        {
            if (ubicacion.id_ubicacion > 0)
            {
                _context.Ubicaciones.Update(ubicacion);
            }
            else
            {
                _context.Ubicaciones.Add(ubicacion);
            }
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> EliminarUbicacion(int id)
        {
            var ubicacion = await _context.Ubicaciones.FindAsync(id);
            if (ubicacion == null) return false;

            _context.Ubicaciones.Remove(ubicacion);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
