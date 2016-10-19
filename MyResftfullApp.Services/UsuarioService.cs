namespace MyResftfullApp.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;

    public class UsuarioService : IUsuarioService
    {
        private readonly IMyResftfullAppContext _context;

        //static UsuarioService()
        //{
        //    var dependency = typeof(SqlProviderServices);
        //}

        public UsuarioService()
            : this(new MyResftfullAppContext())
        {
        }

        public UsuarioService(IMyResftfullAppContext context)
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
