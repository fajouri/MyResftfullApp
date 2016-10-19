
namespace MyResftfullApp.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Context;
    using Services;

    [TestClass]
    public class UsuarioServiceTests
    {
        private UsuarioService service;

        [TestInitialize]
        public void Setup()
        {
            service = new UsuarioService(new MyResftfullAppTestContext());
        }

        [TestMethod]
        public void UsuarioService_GetUsuarios_Devuelve_Lista_De_Usuarios()
        {

            service = new UsuarioService(new MyResftfullAppTestContext());
            var usuarios = service.GetUsuarios();

            Assert.AreEqual(2, usuarios.Count);
            Assert.AreEqual("Fajouri", usuarios[0].Apellido);
            Assert.AreEqual("Suarez", usuarios[1].Apellido);
        }

        [TestMethod]
        public void UsuarioService_GetUsuarioById_Devuelve_Usuario()
        {
            var usuario = service.GetUsuarioById(1);
            Assert.IsNotNull(usuario);
            Assert.AreEqual(1, usuario.Id);
            Assert.AreEqual("Fajouri", usuario.Apellido);
        }

        [TestMethod]
        public void UsuarioService_GetUsuarioById_Devuelve_Null()
        {
            var usuario = service.GetUsuarioById(4);
            Assert.IsNull(usuario);
        }

    }

}

