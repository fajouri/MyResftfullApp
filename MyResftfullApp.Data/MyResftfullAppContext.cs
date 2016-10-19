namespace MyResftfullApp.Data
{
    using System.Data.Entity;
    using Core;
    using Services;


    public class MyResftfullAppContext : DbContext, IMyResftfullAppContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }

        static MyResftfullAppContext()
        {
            Database.SetInitializer(new MyResftfullAppDbInitializer());
        }

        public static MyResftfullAppContext Create()
        {
            return new MyResftfullAppContext();
        }

    }
}
