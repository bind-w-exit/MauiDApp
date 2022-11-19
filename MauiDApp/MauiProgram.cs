using MauiDApp.ViewModels;
using MauiDApp.Views;
using Microsoft.Extensions.Logging;

namespace MauiDApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("Epilogue-Bold.ttf", "EpilogueBold");
                fonts.AddFont("Epilogue-Medium.ttf", "EpilogueMedium");
                fonts.AddFont("Epilogue-Regular.ttf", "EpilogueRegular");
            });

        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<HomePageViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
