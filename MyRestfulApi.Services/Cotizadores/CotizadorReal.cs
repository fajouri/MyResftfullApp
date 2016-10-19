namespace MyRestfulApi.Services.Cotizadores
{
    using System.Net;
    using Core;
    using System.Web.Http;

    public class CotizadorReal: ICotizador
    {
        public Cotizacion Cotizar()
        {
            //Para los parámetros Pesos y Real, implementar un servicio que de una respuesta que sea error 401 no authorized de http.
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}
