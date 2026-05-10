using ControlHardwareSoftware.Components.Data;
using ControlHardwareSoftware.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlHardwareSoftware.Components.Services
{
    public interface IComponenteService
    {
        Task<List<Componente>> ObtenerTodos();
        Task<List<Componente>> ObtenerComponentesPorEquipo(int idEquipo);
        Task<Componente?> ObtenerComponentePorId(int id);
        Task<bool> GuardarComponente(Componente componente);
        Task<bool> EliminarComponente(int id);
    }

    public class ComponenteService : IComponenteService
    {
        private readonly AppDbContext _context;

        public ComponenteService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Componente>> ObtenerTodos() // O modificar ObtenerComponentesPorEquipo
        {
            return await _context.Componentes
                .Include(c => c.Equipo)
                .ToListAsync();
        }


        public async Task<List<Componente>> ObtenerComponentesPorEquipo(int idEquipo)
        {
            return await _context.Componentes
                .Where(c => c.id_equipo == idEquipo)
                .Include(c => c.Equipo)
                .ToListAsync();
        }

        public async Task<Componente?> ObtenerComponentePorId(int id)
        {
            return await _context.Componentes.FindAsync(id);
        }

        public async Task<bool> GuardarComponente(Componente componente)
        {
            try
            {
                if (componente.id_componente > 0)
                {
                    _context.Componentes.Update(componente);
                }
                else
                {
                    _context.Componentes.Add(componente);
                }
                return await _context.SaveChangesAsync() > 0;
            }
            catch (DbUpdateException dbEx)
            {
                // Esto captura errores específicos de SQL (llaves foráneas, etc.)
                var mensaje = dbEx.InnerException?.Message ?? dbEx.Message;
                throw new Exception($"Error de base de datos: {mensaje}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error general: {ex.Message}");
            }
        }



        public async Task<bool> EliminarComponente(int id)
        {
            var componente = await _context.Componentes.FindAsync(id);
            if (componente == null) return false;

            _context.Componentes.Remove(componente);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
