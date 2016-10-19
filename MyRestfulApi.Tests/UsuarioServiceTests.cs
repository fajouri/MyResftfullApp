
namespace MyRestfulApi.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Context;
    using Services;

    [TestClass]
    public class UsuarioServiceTests
    {
        private UsuarioService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new UsuarioService(new MyRestfulApiTestContext());
        }

        [TestMethod]
        public void UsuarioService_GetUsuarios_Devuelve_Lista_De_Usuarios()
        {

            _service = new UsuarioService(new MyRestfulApiTestContext());
            var usuarios = _service.GetUsuarios();

            Assert.AreEqual(2, usuarios.Count);
            Assert.AreEqual("Fajouri", usuarios[0].Apellido);
            Assert.AreEqual("Suarez", usuarios[1].Apellido);
        }

        [TestMethod]
        public void UsuarioService_GetUsuarioById_Devuelve_Usuario()
        {
            var usuario = _service.GetUsuarioById(1);
            Assert.IsNotNull(usuario);
            Assert.AreEqual(1, usuario.Id);
            Assert.AreEqual("Fajouri", usuario.Apellido);
        }

        [TestMethod]
        public void UsuarioService_GetUsuarioById_Devuelve_Null()
        {
            var usuario = _service.GetUsuarioById(4);
            Assert.IsNull(usuario);
        }

    }

}

