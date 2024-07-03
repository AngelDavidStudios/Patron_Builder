namespace Builder_Pattern_Pizzeria.MVVM.Models;

public class Pizza
{
    public string Vel { get; set; }
    public Salsa Salsa { get; set; }
    public Masa Masa { get; set; }
    public List<Agregado> Agregados { get; set; } = new List<Agregado>();

    public string GetPizzaDetails
    {
        get
        {
            var ingredientes = new List<string>
            {
                $"Masa: {Masa?.Descripcion}",
                $"Salsa: {Salsa?.Descripcion}"
            };
            ingredientes.AddRange(Agregados.Select(a => a.Descripcion));
            return string.Join(", ", ingredientes);
        }
    }
}