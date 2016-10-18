namespace MyResftfullApp.Services.Cotizadores
{
    using System.Web.Helpers;
    using Core;
    using Newtonsoft.Json.Linq;
    using Services;
    using WebServices;

    public class CotizadorDolar:ICotizador
    {
        public Cotizacion Cotizar()
        {
            var service = new WebRequestService();
            var result = service.DoServiceCall("http://www.bancoprovincia.com.ar/Principal/Dolar");

            //todo parcear result

            return new Cotizacion() {Comentario = result, Compra =1, Venta = 1 };
        }
    }
}
