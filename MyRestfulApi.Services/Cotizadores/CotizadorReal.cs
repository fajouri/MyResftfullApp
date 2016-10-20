namespace MyRestfulApi.Services.Cotizadores
{
    using System.Net;
    using Core;
    using System.Web.Http;

    public class CotizadorReal: ICotizadorStrategy
    {
        public Cotizacion Cotizar()
        {
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}
