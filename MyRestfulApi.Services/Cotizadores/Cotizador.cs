namespace MyRestfulApi.Services.Cotizadores
{
    using System;
    using Core;

    public class Cotizador
    {
        private ICotizador _cotizadorStrategy;
        private Monedas _moneda;

        public Cotizador(Monedas moneda)
        {
            _cotizadorStrategy = GetCotizadorStrategy(moneda);
        }

        private ICotizador GetCotizadorStrategy(Monedas moneda)
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

        public Monedas Moneda
        {
            get { return _moneda; }
            set
            {
                _moneda = value;
                _cotizadorStrategy = GetCotizadorStrategy(value);
            }
        }

        public Cotizacion GetCotizacion()
        {
            return _cotizadorStrategy.Cotizar();
        }
    }
}
