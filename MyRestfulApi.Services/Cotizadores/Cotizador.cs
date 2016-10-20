namespace MyRestfulApi.Services.Cotizadores
{
    using System;
    using Core;

    public class Cotizador: ICotizador
    {
        private ICotizadorStrategy _cotizadorStrategy;
        private Monedas _moneda;

        public Cotizador(Monedas moneda)
        {
            _cotizadorStrategy = GetCotizadorStrategy(moneda);
        }

        public Cotizador()
        {
            _cotizadorStrategy = GetCotizadorStrategy(Monedas.Pesos);
        }

        public ICotizadorStrategy GetCotizadorStrategy(Monedas moneda)
        {
            switch (moneda)
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

        public Cotizacion GetCotizacion()
        {
            return _cotizadorStrategy.Cotizar();
        }

        public Monedas Moneda
        {
            get { return _moneda; }
            set
            {
                _moneda = value;
                _cotizadorStrategy = GetCotizadorStrategy(value);
            }
        }
    }
}
