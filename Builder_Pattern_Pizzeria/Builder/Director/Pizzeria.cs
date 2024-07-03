using Builder_Pattern_Pizzeria.Interfaces;
using Builder_Pattern_Pizzeria.MVVM.Models;

namespace Builder_Pattern_Pizzeria.Builder.Director;

public class Pizzeria
{
    private IPizzaBuilder _pizzaBuilder;

    public void SetPizzaBuilder(IPizzaBuilder pizzaBuilder)
    {
        _pizzaBuilder = pizzaBuilder;
    }

    public Pizza BuildPizza()
    {
        _pizzaBuilder.BuildMasa();
        _pizzaBuilder.BuildSalsa();
        _pizzaBuilder.BuildAgregados();
        return _pizzaBuilder.GetPizza();
    }
}