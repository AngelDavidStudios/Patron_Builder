using Builder_Pattern_Pizzeria.Interfaces;
using Builder_Pattern_Pizzeria.MVVM.Models;

namespace Builder_Pattern_Pizzeria.Builder;

public class PizzaMuzzaBuilder: IPizzaBuilder
{
    private Pizza _pizza = new Pizza();

    public void BuildSalsa()
    {
        _pizza.Salsa = new Salsa { Descripcion = "Salsa de Tomate" };
    }

    public void BuildMasa()
    {
        _pizza.Masa = new Masa { Descripcion = "Masa al Molde" };
    }

    public void BuildAgregados()
    {
        _pizza.Agregados.Add(new Agregado { Descripcion = "Queso Mozzarella" });
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}