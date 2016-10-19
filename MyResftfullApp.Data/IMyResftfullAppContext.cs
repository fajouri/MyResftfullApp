namespace MyResftfullApp.Data
{
    using System.Data.Entity;
    using Core;
    using Services;

    public interface IMyResftfullAppContext
    {
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Cotizacion> Cotizaciones { get; set; }
    }
}
