namespace MyRestfulApi.Services.Cotizadores
{
    using Core;

    public interface ICotizadorStrategy
    {
        Cotizacion Cotizar();
    }
}
