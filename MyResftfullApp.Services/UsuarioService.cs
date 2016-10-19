using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResftfullApp.Services
{
    using Data;
    using Services;

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
            //return new Usuario()
            //{
            //    Id = 1,
            //    Apellido = "Fajouri",
            //    Email = "123@123.com",
            //    Nombre = "Yamil",
            //    Password = "123456"
            //};
        }

        public IList<Usuario> GetUsuarios()
        {
            return _context.Usuarios.ToList();
            //return new List<Usuario>{new Usuario{ Id = 1, Apellido = "Fajouri", Email = "123@123.com", Nombre = "Yamil", Password = "123456"},
            //    new Usuario{ Id = 2, Apellido = "Suarez", Email = "123@123.com", Nombre = "Gonzalo", Password = "123456" } };
        }
    }

}
