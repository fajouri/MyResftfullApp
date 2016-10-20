namespace MyRestfulApi.Services
{
    using System;
    using Core;
    using Cotizadores;

    public class CotizacionService : ICotizacionService
    {
        private ICotizador _cotizador;

        public CotizacionService(ICotizador cotizador)
        {
            _cotizador = cotizador;
        }

        public CotizacionService():this(new Cotizador())
        {
        }

        public Cotizacion GetCotizacion(string moneda)
        {
            Monedas monedaValue;

            if (!Enum.TryParse(moneda, out monedaValue))
                throw new ArgumentOutOfRangeException(nameof(moneda), moneda, null);

            return _cotizador.GetCotizadorStrategy(monedaValue).Cotizar();
        }
    }

}
