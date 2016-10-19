namespace MyRestfulApi.Services.Cotizadores
{
    using System.Globalization;
    using Core;
    using WebServices;

    public class CotizadorDolar:ICotizador
    {
        public Cotizacion Cotizar()
        {
            var service = new WebRequestService();
            var result = service.DoServiceCall("http://www.bancoprovincia.com.ar/Principal/Dolar");
            var stringCotizacion = result.Replace("[","").Replace("]", "").Replace("\"","").Split(',');
            var cultura = CultureInfo.InvariantCulture.Clone() as CultureInfo;
            cultura.NumberFormat.NumberDecimalSeparator = ".";
            return new Cotizacion() {Comentario = stringCotizacion[2], Compra = decimal.Parse(stringCotizacion[0], cultura), Venta = decimal.Parse(stringCotizacion[1], cultura) };
        }
    }
}
