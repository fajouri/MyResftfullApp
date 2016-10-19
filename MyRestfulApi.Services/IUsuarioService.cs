namespace MyRestfulApi.Services
{
    using System.Collections.Generic;
    using Core;

    public interface IUsuarioService
    {
        Usuario GetUsuarioById(int id);
        IList<Usuario> GetUsuarios();
    }
}