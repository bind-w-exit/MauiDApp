namespace MauiDApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //App.Current.UserAppTheme = AppTheme.Light;

        if (DeviceInfo.Idiom == DeviceIdiom.Phone)
        {
            MainPage = new AppShellMobile();
        }
        else
        {
            MainPage = new AppShellDesktop();
        }
    }
}
