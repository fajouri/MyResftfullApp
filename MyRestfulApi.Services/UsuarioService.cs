namespace MyRestfulApi.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Core;
    using Data;

    public class UsuarioService : IUsuarioService
    {
        private readonly IMyRestfulApiContext _context;

        public UsuarioService()
            : this(new MyRestfulApiContext())
        {
        }

        public UsuarioService(IMyRestfulApiContext context)
        {
            _context = context;
        }

        public Usuario GetUsuarioById(int id)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public IList<Usuario> GetUsuarios()
        {

            return _context.Usuarios.ToList();
        }
    }

}
