namespace MyRestfulApi.Core
{
    using System.ComponentModel.DataAnnotations;

    public enum Monedas
    {
        [Display(Name = "Pesos")] Pesos = 0,
        [Display(Name = "Dolar")] Dolar = 1,
        [Display(Name = "Real")] Real = 2
    }
}
