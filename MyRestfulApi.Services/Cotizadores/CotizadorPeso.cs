namespace MyRestfulApi.Services.Cotizadores
{
    using System.Net;
    using System.Web.Http;
    using Core;

    public class CotizadorPeso:ICotizadorStrategy
    {
        public Cotizacion Cotizar()
        {
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}
