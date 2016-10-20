namespace MyRestfulApi.Tests.Context
{
    using System.Data.Entity;
    using Core;
    using Data;

    public class MyRestfulApiTestContext : IMyRestfulApiContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }

        public MyRestfulApiTestContext()
        {
            Usuarios = new TestDbSet<Usuario>();
            Cotizaciones = new TestDbSet<Cotizacion>();
            Inicializar();
        }

        private void Inicializar() => new TestContextInitializerStub(this);
    }
}
