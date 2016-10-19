namespace MyResftfullApp.Services.Cotizadores
{
    using System.Net;
    using System.Web.Http;
    using Core;

    public class CotizadorPeso:ICotizador
    {
        public Cotizacion Cotizar()
        {
            //Para los parámetros Pesos y Real, implementar un servicio que de una respuesta que sea error 401 no authorized de http.
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}
