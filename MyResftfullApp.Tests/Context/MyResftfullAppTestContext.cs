namespace MyResftfullApp.Tests.Context
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Core;
    using Data;
    using Services;


    public class MyResftfullAppTestContext : IMyResftfullAppContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }

        public MyResftfullAppTestContext()
        {
            this.Usuarios = new TestDbSet<Usuario>();
            this.Cotizaciones = new TestDbSet<Cotizacion>();
            Inicializar();
        }

        private void Inicializar()
        {
            new TestContextInitializerStub(this);
        }
    }
}
