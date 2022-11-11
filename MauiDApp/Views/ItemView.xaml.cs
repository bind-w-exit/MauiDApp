using MauiDApp.ViewModels;

namespace MauiDApp.Views;

public partial class ItemView : ContentView
{
    public ItemView()
	{
		InitializeComponent();

        //Currently binding in DataTempalate
        //BindingContext = new ItemViewModel(); 
    }

}