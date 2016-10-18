namespace MyResftfullApp.Services
{
    using System.Collections.Generic;
    using Services;

    public interface IUsuarioService
    {
        Usuario GetUsuarioById(int id);
        IList<Usuario> GetUsuarios();
    }
}