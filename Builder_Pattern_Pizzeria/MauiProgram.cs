using Builder_Pattern_Pizzeria.Builder;
using Builder_Pattern_Pizzeria.Builder.Director;
using Builder_Pattern_Pizzeria.Interfaces;
using Builder_Pattern_Pizzeria.MVVM.ViewModels;
using Microsoft.Extensions.Logging;

namespace Builder_Pattern_Pizzeria;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        
        builder.Services.AddSingleton<Pizzeria>();
        builder.Services.AddTransient<IPizzaBuilder, PizzaLightBuilder>();
        builder.Services.AddTransient<IPizzaBuilder, PizzaItalianaBuilder>();
        builder.Services.AddTransient<IPizzaBuilder, PizzaMuzzaBuilder>();
        builder.Services.AddTransient<PizzaViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}