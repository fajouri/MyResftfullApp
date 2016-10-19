namespace MyRestfulApi.Data
{
    using System.Data.Entity;
    using Core;

    public interface IMyRestfulApiContext
    {
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Cotizacion> Cotizaciones { get; set; }
    }
}
