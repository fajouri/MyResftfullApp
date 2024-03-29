﻿namespace MyRestfulApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using Core;
    using Services;

    public class UsuarioController : ApiController
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController()
            : this(new UsuarioService())
        {
        }

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET api/<controller>
        public IEnumerable<Usuario> Get()
        {
            return _usuarioService.GetUsuarios();
        }

        // GET api/<controller>/5
        public Usuario Get(int id)
        {
            return _usuarioService.GetUsuarioById(id);
        }

        // POST api/<controller>
        public void Post(Usuario usuario)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, Usuario usuario)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}