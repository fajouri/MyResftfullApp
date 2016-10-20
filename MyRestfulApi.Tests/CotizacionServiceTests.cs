namespace MyRestfulApi.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Core;
    using Services;
    using Stub;

    [TestClass]
    public class CotizacionServiceTests
    {
        private CotizacionService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new CotizacionService(new CotizadorStub());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CotizacionService_GetCotizacion_Fake_Moneda_Returns_Exception()
        {
            _service.GetCotizacion("FakeMoneda");
        }

        [TestMethod]
        public void CotizacionService_GetCotizacion_Moneda_ReturnsCotizacion()
        {
         var cotizacion = _service.GetCotizacion(Monedas.Pesos.ToString());
            Assert.IsNotNull(cotizacion);
            Assert.IsTrue(string.CompareOrdinal(cotizacion.Comentario, "Test Cotizacion")==0);
        }

    }
}
