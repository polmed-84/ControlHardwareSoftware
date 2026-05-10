using ControlHardwareSoftware.Components.Data;
using ControlHardwareSoftware.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlHardwareSoftware.Components.Services
{
    public interface IEquipoService
    {
        Task<List<Equipo>> ObtenerEquipos();
        Task<Equipo?> ObtenerEquipoPorId(int id);
        Task<bool> GuardarEquipo(Equipo equipo);
        Task<bool> EliminarEquipo(int id);
    }

    public class EquipoService : IEquipoService
    {
        private readonly AppDbContext _context;
        public EquipoService(AppDbContext context) => _context = context;

        public async Task<List<Equipo>> ObtenerEquipos() =>
            await _context.Equipos
                .Include(e => e.Usuario)
                .Include(e => e.Ubicacion)
                .ToListAsync();

        public async Task<Equipo?> ObtenerEquipoPorId(int id) =>
            await _context.Equipos
                .AsNoTracking()
                .Where(s=>s.id_equipo == id)
                .Include(e => e.Componentes)
                .Include(e => e.Usuario)
                .Include(e => e.Ubicacion)
                .Include(s=>s.SoftwaresInstalados)
                .ThenInclude(e => e.Software)
                .Include(s => s.SoftwaresInstalados)
                .ThenInclude(s=>s.Licencia)
                .Include(s=>s.Mantenimientos)
                .FirstOrDefaultAsync(e => e.id_equipo == id);

        public async Task<bool> GuardarEquipo(Equipo equipo)
        {
            if (equipo.id_equipo > 0)
                _context.Equipos.Update(equipo);
            else
                _context.Equipos.Add(equipo);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> EliminarEquipo(int id)
        {
            var equipo = await _context.Equipos.FindAsync(id);
            if (equipo == null) return false;

            _context.Equipos.Remove(equipo);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
