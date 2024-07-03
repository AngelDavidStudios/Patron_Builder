using Builder_Pattern_Pizzeria.MVVM.Models;

namespace Builder_Pattern_Pizzeria.Interfaces;

public interface IPizzaBuilder
{
    void BuildSalsa();
    void BuildMasa();
    void BuildAgregados();
    Pizza GetPizza();
}