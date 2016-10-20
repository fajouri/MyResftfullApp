namespace MyRestfulApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Web.Http;
    using Core;
    using Services;

    public class CotizacionController : ApiController
    {
        private readonly ICotizacionService _cotizacionService;

        public CotizacionController()
            : this(new CotizacionService())
        {
        }

        public CotizacionController(ICotizacionService cotizacionService)
        {
            _cotizacionService = cotizacionService;
        }


        // GET <controller>
        public IEnumerable<Cotizacion> Get()
        {
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }

        // GET <controller>/5
        [Route("Cotizacion/{moneda}")]
        public Cotizacion Get(string moneda)
        {
            if (string.IsNullOrEmpty(moneda))
                throw new ArgumentException("Value cannot be null or empty.", nameof(moneda));

            return _cotizacionService.GetCotizacion(moneda);
        }

        // POST api/<controller>
        public void Post(Cotizacion cotizacion)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, Cotizacion cotizacion)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
