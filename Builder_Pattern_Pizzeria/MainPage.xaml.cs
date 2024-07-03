using Builder_Pattern_Pizzeria.Builder;
using Builder_Pattern_Pizzeria.Builder.Director;
using Builder_Pattern_Pizzeria.MVVM.ViewModels;

namespace Builder_Pattern_Pizzeria;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        // Instancias de los builders específicos para cada tipo de pizza
        var pizzaLightBuilder = new PizzaLightBuilder();
        var pizzaItalianaBuilder = new PizzaItalianaBuilder();
        var pizzaMuzzaBuilder = new PizzaMuzzaBuilder();

        // Instancia de Pizzeria
        var pizzeria = new Pizzeria();

        // Creación del ViewModel con las dependencias necesarias
        var viewModel = new PizzaViewModel(pizzeria, pizzaLightBuilder, pizzaItalianaBuilder, pizzaMuzzaBuilder);

        // Establecer el contexto de enlace a la instancia de ViewModel
        BindingContext = viewModel;
    }
    
}