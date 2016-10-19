namespace MyRestfulApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;
    using Core;
    using Services;

    public class CotizacionController : ApiController
    {


        // GET api/<controller>
        public IEnumerable<Cotizacion> Get()
        {
            yield break;
        }

        // GET api/<controller>/5
        [Route("api/Cotizacion/{moneda}")]
        public Cotizacion Get(string moneda)
        {
            if (string.IsNullOrEmpty(moneda))
                throw new ArgumentException("Value cannot be null or empty.", nameof(moneda));

            return new CotizacionService(moneda).GetCotizacion();
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
