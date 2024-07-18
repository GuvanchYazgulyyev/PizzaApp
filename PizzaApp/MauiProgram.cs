using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PizzaApp.Pages;
using PizzaApp.Services;
using PizzaApp.ViewModels;

namespace PizzaApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");  // Roboto fontunu ekledik
                });


#if DEBUG
            builder.Logging.AddDebug();
#endif
            AddPizzaServices(builder.Services);
            return builder.Build();
        }

        private static IServiceCollection AddPizzaServices(IServiceCollection services)
        {
            services.AddSingleton<PizzaServices>();
            services.AddSingletonWithShellRoute<HomePage, HomeViewModel>(nameof(HomePage));
            return services;
        }
    }
}
