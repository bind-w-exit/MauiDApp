using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDApp.Models;
using System.Collections.ObjectModel;

namespace MauiDApp.ViewModels
{
    public partial class HomePageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private bool isRefreshing;

        [ObservableProperty]
        private bool boll;

        private ObservableCollection<Item> items;

        [ObservableProperty]
        private ObservableCollection<ItemViewModel> itemsVM;

        public HomePageViewModel()
        {
            items = new ObservableCollection<Item>()
            {
                new Item(
                    1,
                    "https://i.seadn.io/gae/DWs2FaaCdz9HAHlVEvRtkxEjuBold3PZgcNFBPZmk5tJaflGprJ5bOwMYuv8ecTAkoKcm4P9PJG1BjisFhKEhcFfNVi5pYpPYev93CE?auto=format&w=1920",
                    "You #7285",
                    "C4EA96",
                    true),
                new Item(
                    2,
                    "https://i.seadn.io/gae/FpavCWmJDAMBLsOUNK-F_Zva-EJhcRqvAXUrR0JDLGEddoP4jpfiPCXX9gG5hQJzAQdpVPOs68ugV7WCFz1bffnJ-ne71SzflEyk6Q?auto=format&w=1920",
                    "You #7286",
                    "C4EA96",
                    false),
                new Item(
                    3,
                    "https://i.seadn.io/gae/vuNg_s3yNSK2mL6Yg3SwuOvbu2t3y0g73U4txfqSCmefnZUT0bqrT5peywA4kczv8drQLQ7YhmKdUVkq6o3-hynMdvVL5t7uSRVJtrg?auto=format&w=1920",
                    "You #7287",
                    "C4EA97",
                    false),
                new Item(
                    4,
                    "https://i.seadn.io/gae/DTSLUfiq6xY2dXHwcjnKO2nOu10O5_eKoBTP3Hv09S2pmyMwVhROMOIQDP5nx28CWzW83b1qlhmY0NHrFFb3pApGA9XheX4wFUe-4A?auto=format&w=1920",
                    "You #7288",
                    "C4EA97",
                    true)
            };

            itemsVM = new ObservableCollection<ItemViewModel>();

            foreach (var item in items)
            {
                itemsVM.Add(new ItemViewModel(item));
            }
        }

        [RelayCommand]
        private async void Refresh()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(5));
            IsRefreshing = false;
        }

    }
}
