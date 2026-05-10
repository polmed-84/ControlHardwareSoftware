using ControlHardwareSoftware.Components.Models;
using ControlHardwareSoftware.Components.Data;
using Microsoft.EntityFrameworkCore;

namespace ControlHardwareSoftware.Components.Services
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> ObtenerUsuarios();
        Task<Usuario> ObtenerUsuarioPorId(int id);
        Task<bool> GuardarUsuario(Usuario usuario);
        Task<bool> EliminarUsuario(int id);
    }

    public class UsuarioService : IUsuarioService   
    {
        private readonly AppDbContext _context;
        public UsuarioService(AppDbContext context) => _context = context;

        public async Task<List<Usuario>> ObtenerUsuarios() => await _context.Usuarios.ToListAsync();

        public async Task<Usuario> ObtenerUsuarioPorId(int id) => await _context.Usuarios.FindAsync(id);

        public async Task<bool> GuardarUsuario(Usuario usuario)
        {
            if (usuario.id_usuario > 0) _context.Usuarios.Update(usuario);
            else _context.Usuarios.Add(usuario);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> EliminarUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null) return false;
            _context.Usuarios.Remove(usuario);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
