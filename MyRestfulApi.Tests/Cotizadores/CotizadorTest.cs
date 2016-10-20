namespace MyRestfulApi.Tests.Cotizadores
{
    using System.Web.Http;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Core;
    using Services.Cotizadores;

    [TestClass]
    public class CotizadorTest
    {
        [TestMethod]
        public void Moneda_Default_Moneda_Peso()
        {
            var cotizador = new Cotizador();

            Assert.IsTrue(cotizador.Moneda==Monedas.Pesos);
        }

        [TestMethod]
        public void GetCotizadorStrategy_Moneda_Dolar_Returns_Moneda_Dolar()
        {
            var cotizador = new Cotizador();

            var cotizadorStrategy = cotizador.GetCotizadorStrategy(Monedas.Dolar);

            Assert.IsInstanceOfType(cotizadorStrategy, typeof(CotizadorDolar));
        }

        [TestMethod]
        public void GetCotizadorStrategy_Moneda_Peso_Returns_Moneda_Peso()
        {
            var cotizador = new Cotizador();

            var cotizadorStrategy = cotizador.GetCotizadorStrategy(Monedas.Pesos);

            Assert.IsInstanceOfType(cotizadorStrategy, typeof(CotizadorPeso));
        }

        [TestMethod]
        public void GetCotizadorStrategy_Real_Dolar_Create_Returns_Moneda_Real()
        {
            var cotizador = new Cotizador();

            var cotizadorStrategy = cotizador.GetCotizadorStrategy(Monedas.Real);

            Assert.IsInstanceOfType(cotizadorStrategy, typeof(CotizadorReal));
        }


       

        [TestMethod]
        [ExpectedException(typeof(HttpResponseException))]
        public void GetCotizacion_Moneda_Peso_Returns_Moneda_Peso()
        {
            var cotizador = new Cotizador();

            cotizador.Moneda = Monedas.Pesos;

         cotizador.GetCotizacion();
        }

        [TestMethod]
        [ExpectedException(typeof(HttpResponseException))]
        public void GetCotizacion_Real_Create_Returns_Moneda_Real()
        {
            var cotizador = new Cotizador();

            cotizador.Moneda = Monedas.Real;

            cotizador.GetCotizacion();

        }



    }
}