namespace MyResftfullApp.Services
{
    using System;
    using Core;
    using Cotizadores;
    using CotizadorDolar = Cotizadores.CotizadorDolar;

    public class CotizacionService
    {
        private ICotizador _cotizadorStrategy;
        private Monedas _moneda;

        public CotizacionService(string moneda)
        {
            _cotizadorStrategy = GetCotizadorStrategy(moneda);
        }

        private ICotizador GetCotizadorStrategy(string moneda)
        {
            Monedas monedaValue;

            if (!Enum.TryParse(moneda, out monedaValue))
                throw new ArgumentOutOfRangeException(nameof(moneda), moneda, null);

            switch (monedaValue)
            {
                case Monedas.Pesos:
                    return new CotizadorPeso();
                case Monedas.Dolar:
                    return new CotizadorDolar();
                case Monedas.Real:
                    return new CotizadorReal();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public Monedas Moneda
        {
            get { return _moneda; }
            set
            {
                _moneda = value;
                _cotizadorStrategy = GetCotizadorStrategy(value.ToString());
            }
        }

        public Cotizacion GetCotizacion()
        {
            return _cotizadorStrategy.Cotizar();
        }
    }
}
