using Builder_Pattern_Pizzeria.Interfaces;
using Builder_Pattern_Pizzeria.MVVM.Models;

namespace Builder_Pattern_Pizzeria.Builder;

public class PizzaItalianaBuilder: IPizzaBuilder
{
    private Pizza _pizza = new Pizza();

    public void BuildSalsa()
    {
        _pizza.Salsa = new Salsa { Descripcion = "Salsa Italiana" };
    }

    public void BuildMasa()
    {
        _pizza.Masa = new Masa { Descripcion = "Masa a la Piedra" };
    }

    public void BuildAgregados()
    {
        _pizza.Agregados.Add(new Agregado { Descripcion = "Tomate" });
        _pizza.Agregados.Add(new Agregado { Descripcion = "Oliva" });
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}