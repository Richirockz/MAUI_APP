using MauiApp2.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiApp2
{
    public static MauiApp CreateMauiApp()
    {
        {    var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
