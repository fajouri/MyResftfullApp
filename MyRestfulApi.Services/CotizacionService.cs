namespace MyRestfulApi.Services
{
    using System;
    using Core;
    using Cotizadores;

    public class CotizacionService : ICotizacionService
    {
        private Cotizador _cotizador;

        public CotizacionService(Cotizador cotizador)
        {
            _cotizador = cotizador;
        }

        public CotizacionService()
        {
        }

        public Cotizacion GetCotizacion(string moneda)
        {
            Monedas monedaValue;

            if (!Enum.TryParse(moneda, out monedaValue))
                throw new ArgumentOutOfRangeException(nameof(moneda), moneda, null);

            if (_cotizador == null)
                _cotizador = new Cotizador(monedaValue);
            else
                _cotizador.Moneda = monedaValue;

            return _cotizador.GetCotizacion();
        }
    }

}
