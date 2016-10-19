namespace MyRestfulApi.Services
{
    using Core;

    public interface ICotizacionService
    {
        Cotizacion GetCotizacion(string moneda);
    }
}
