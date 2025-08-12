using Microsoft.Extensions.Logging;
using MyTeam2.Services;
using MyTeam2.Services.Interfaces;

namespace MyTeam2
{
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

#if DEBUG
            builder.Logging.AddDebug();

            // Uncomment to clear preferences for debugging purposes
            // Preferences.Clear();
#endif

            // Register services
            builder.Services.AddSingleton<IDataService, DataService>();
            builder.Services.AddSingleton<IAppSettings, AppSettings>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();

            return builder.Build();
        }
    }
}
