namespace MyRestfulApi.Data
{
    using System.Data.Entity;
    using Core;

    public class MyRestfulApiDbInitializer : CreateDatabaseIfNotExists<MyRestfulApiContext>
    {
        protected override void Seed(MyRestfulApiContext context)
        {
            context.Usuarios.Add(new Usuario { Id = 1, Apellido = "Ramos", Nombre = "Martin", Email = "ramos.martin@123.com", Password = "123456" });
            context.Usuarios.Add(new Usuario { Id = 2, Apellido = "Guerrero", Nombre = "Nicolas", Email = "guerrero.nicolas@123.com", Password = "123456" });
            context.Usuarios.Add(new Usuario { Id = 3, Apellido = "Fajouri", Nombre = "Yamil", Email = "fajouri.yamil@123.com", Password = "123456" });
            context.Usuarios.Add(new Usuario { Id = 4, Apellido = "Suarez", Nombre = "Gonzalo", Email = "suarez.gonzalo@123.com", Password = "123456" });
            context.Usuarios.Add(new Usuario { Id = 5, Apellido = "Ramis", Nombre = "Leonel", Email = "ramis.leonel@123.com", Password = "123456" });
            context.SaveChanges();
        }
    }
}
