
namespace MyResftfullApp.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using Data;
    using Services;

    [TestClass]
    public class UsuarioServiceTests
    {
        private IUsuarioService service;
        private IMyResftfullAppContext context;

        //[TestInitialize]
        //public void Setup()
        //{
        //    //context = new PortalIntegradoGs1Api.Tests.Context.TestContext();
        //    //service = new UsuarioService(context, emailSender, new ExpressionBuilderServiceStub());
        //    context= Mock 
        //    service = new UsuarioService();
        //}

        //[TestMethod]
        //public void UsuarioService_GetUsuarios_Devuelve_Lista_De_Usuarios()
        //{
        //    var result = service.GetUsuarios();

        //    Assert.IsNotNull(result);
        //    Assert.IsInstanceOfType(result, typeof(List<Usuario>));
        //}

    }
}

