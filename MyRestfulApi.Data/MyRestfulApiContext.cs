namespace MyRestfulApi.Data
{
    using System.Data.Entity;
    using Core;


    public class MyRestfulApiContext : DbContext, IMyRestfulApiContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }

        static MyRestfulApiContext()
        {
            //Database.SetInitializer(new MyRestfulApiDbInitializer());
        }

        public static MyRestfulApiContext Create()
        {
            return new MyRestfulApiContext();
        }

    }
}
