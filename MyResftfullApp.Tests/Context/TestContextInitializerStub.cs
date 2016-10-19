namespace MyResftfullApp.Tests.Context
{
    using Services;

    internal class TestContextInitializerStub
    {
        private readonly MyResftfullAppTestContext _testContext;

        public TestContextInitializerStub(MyResftfullAppTestContext testContext)
        {
            _testContext = testContext;
            CrearUsuarios();
        }

        private void CrearUsuarios()
        {
            _testContext.Usuarios.Add(new Usuario { Id = 1, Apellido = "Fajouri", Email = "123@123.com", Nombre = "Yamil", Password = "123456" });
            _testContext.Usuarios.Add(new Usuario { Id = 2, Apellido = "Suarez", Email = "123@123.com", Nombre = "Gonzalo", Password = "123456" });
        }
    }
}