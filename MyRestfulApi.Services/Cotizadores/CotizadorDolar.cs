namespace MyRestfulApi.Services.Cotizadores
{
    using System.Globalization;
    using Core;
    using Core.Helpers;
    using WebServices;

    public class CotizadorDolar:ICotizadorStrategy
    {
        private readonly IWebRequestService _webRequestService;
        private IConfigurationManagerHelper _configurationManagerHelper;

        public CotizadorDolar(IWebRequestService webRequestService, IConfigurationManagerHelper configurationManagerHelper)
        {
            _webRequestService = webRequestService;
            _configurationManagerHelper = configurationManagerHelper;
        }

        public CotizadorDolar() : this(new WebRequestService(), new ConfigurationManagerHelper())
        {

        }

        public Cotizacion Cotizar()
        {

            var setting = _configurationManagerHelper.GetAppSettings("UrlCotizacionDolar");

            var result = _webRequestService.DoServiceCall(setting);

            var stringCotizacion = result.Replace("[","").Replace("]", "").Replace("\"","").Split(',');

            var cultura = CultureInfo.InvariantCulture.Clone() as CultureInfo;

            cultura.NumberFormat.NumberDecimalSeparator = ".";

            return new Cotizacion() {Comentario = stringCotizacion[2], Compra = decimal.Parse(stringCotizacion[0], cultura), Venta = decimal.Parse(stringCotizacion[1], cultura) };
        }
    }
}
