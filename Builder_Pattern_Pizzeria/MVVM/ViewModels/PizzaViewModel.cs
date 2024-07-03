using Builder_Pattern_Pizzeria.Builder.Director;
using Builder_Pattern_Pizzeria.Interfaces;
using Builder_Pattern_Pizzeria.MVVM.Models;
using PropertyChanged;

namespace Builder_Pattern_Pizzeria.MVVM.ViewModels;

[AddINotifyPropertyChangedInterface]
public class PizzaViewModel
{
    private readonly Pizzeria _pizzeria;
    private readonly IPizzaBuilder _pizzaLightBuilder;
    private readonly IPizzaBuilder _pizzaItalianaBuilder;
    private readonly IPizzaBuilder _pizzaMuzzaBuilder;
    
    public PizzaViewModel(Pizzeria pizzeria, IPizzaBuilder pizzaLightBuilder, IPizzaBuilder pizzaItalianaBuilder, IPizzaBuilder pizzaMuzzaBuilder)
    {
        _pizzeria = pizzeria;
        _pizzaLightBuilder = pizzaLightBuilder;
        _pizzaItalianaBuilder = pizzaItalianaBuilder;
        _pizzaMuzzaBuilder = pizzaMuzzaBuilder;
    }
    
    public Pizza Pizza { get; set; }
    
    public Command<string> BuildPizzaCommand => new Command<string>(BuildPizza);
    
    private void BuildPizza(string pizzaType)
    {
        switch (pizzaType)
        {
            case "Light":
                _pizzeria.SetPizzaBuilder(_pizzaLightBuilder);
                break;
            case "Italiana":
                _pizzeria.SetPizzaBuilder(_pizzaItalianaBuilder);
                break;
            case "Muzza":
                _pizzeria.SetPizzaBuilder(_pizzaMuzzaBuilder);
                break;
            default:
                return;
        }

        Pizza = _pizzeria.BuildPizza();
    }

}