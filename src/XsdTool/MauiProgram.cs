using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using XsdTool.Shared.DependencyInjection;

namespace XsdTool
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            RegisterDepencencies(builder.Services, new Presentation.DependencyRegistrant());

            return builder.Build();
        }

        public static void RegisterDepencencies(IServiceCollection container, IDependenyRegistrant registrant)
        {
            registrant.Register(container);
        }
    }
}
