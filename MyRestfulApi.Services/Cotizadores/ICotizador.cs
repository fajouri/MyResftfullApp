namespace MyRestfulApi.Services.Cotizadores
{
    using Core;

    public interface ICotizador
    {
        Cotizacion GetCotizacion();
        ICotizadorStrategy GetCotizadorStrategy(Monedas moneda);

    }
}
