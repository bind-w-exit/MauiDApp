using MauiDApp.ViewModels;

namespace MauiDApp.Views;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}