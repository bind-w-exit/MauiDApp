using MauiDApp.ViewModels;
using MauiDApp.Views;

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
            });

		builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<HomePageViewModel>();

        return builder.Build();
	}
}
