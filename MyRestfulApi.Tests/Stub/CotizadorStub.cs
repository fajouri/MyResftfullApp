namespace MyRestfulApi.Tests.Stub
{
    using Core;
    using Services.Cotizadores;

    public class CotizadorStub: ICotizador
    {
        public Cotizacion GetCotizacion()
        {
            return new Cotizacion {Comentario = "Test Cotizacion", Compra = 1, Venta = 2};
        }

        public ICotizadorStrategy GetCotizadorStrategy(Monedas moneda)
        {
          return new CotizadorStrategyStub();
        }

        public void SetMoneda(Monedas moneda)
        {
           
        }
    }

    public class CotizadorStrategyStub : ICotizadorStrategy
    {
        public Cotizacion Cotizar()
        {
            return new Cotizacion { Comentario = "Test Cotizacion", Compra = 1, Venta = 2 };
        }
    }
}
