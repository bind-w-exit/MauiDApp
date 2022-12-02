using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDApp.Services;
using System.Collections.ObjectModel;

namespace MauiDApp.ViewModels;

public partial class HomePageViewModel : BaseViewModel
{
    [ObservableProperty]
    private bool isRefreshing;

    [ObservableProperty]
    private ObservableCollection<ItemViewModel> itemsVM;

    [ObservableProperty]
    private ItemViewModel itemVM;

    public HomePageViewModel()
    {
        itemsVM = new ObservableCollection<ItemViewModel>();

        for (int i = 0; i < 5; i++)
        {
            itemsVM.Add(new ItemViewModel(NftService.GetItem()));
        }

        itemVM = new ItemViewModel(NftService.GetItem());
    }

    [RelayCommand]
    private async void Refresh()
    {
        IsRefreshing = true;
        await Task.Delay(TimeSpan.FromSeconds(5));
        IsRefreshing = false;
    }

}
