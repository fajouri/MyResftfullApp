namespace MyRestfulApi.Tests.Cotizadores
{
    using Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services.Cotizadores;
    using Stub;

    [TestClass]
    public class CotizadorDolarTest
    {
        [TestMethod]
        public void GetCotizacion_Moneda_Dolar_Returns_Moneda_Dolar()
        {
            var cotizador = new CotizadorDolar(new WebRequestServiceStub(), new ConfigurationManagerHelperStub());

            var cotizacion = cotizador.Cotizar();

            Assert.IsInstanceOfType(cotizacion, typeof(Cotizacion));
            Assert.IsTrue(cotizacion.Venta==(decimal)15.4);
            Assert.IsTrue(cotizacion.Compra == 15);
        }
    }
}
