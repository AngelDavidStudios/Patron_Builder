using Builder_Pattern_Pizzeria.Interfaces;
using Builder_Pattern_Pizzeria.MVVM.Models;

namespace Builder_Pattern_Pizzeria.Builder;

public class PizzaLightBuilder: IPizzaBuilder
{
    private Pizza _pizza = new Pizza();

    public void BuildSalsa()
    {
        _pizza.Salsa = new Salsa { Descripcion = "Salsa Light" };
    }

    public void BuildMasa()
    {
        _pizza.Masa = new Masa { Descripcion = "Masa Integral" };
    }

    public void BuildAgregados()
    {
        _pizza.Agregados.Add(new Agregado { Descripcion = "Oregano" });
        _pizza.Agregados.Add(new Agregado { Descripcion = "Tomate" });
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}