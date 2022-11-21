using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDApp.Models;
using MauiDApp.Services;
using System.Globalization;

namespace MauiDApp.ViewModels
{
    public partial class ItemViewModel : BaseViewModel
    {
        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private string imageUrl;

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private string creator;

        [ObservableProperty]
        private bool isFavorite;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ReservePriceEth))]
        [NotifyPropertyChangedFor(nameof(ReservePriceUsd))]
        private double reservePrice;

        public string ReservePriceEth { get => Math.Round(reservePrice, 2).ToString("F2", new CultureInfo("en-US", false)) + " ETH"; }
        public string ReservePriceUsd { get => (reservePrice * NftService.ETHPrice).ToString("C", new CultureInfo("en-US", false)); }

        public ItemViewModel(Item item)
        {
            Id = item.Id;
            ImageUrl = item.ImageUrl;
            Title = item.Title;
            Creator = item.Creator;
            IsFavorite = item.IsFavorite;
            ReservePrice = item.ReservePrice;
        }

        [RelayCommand]
        void ItemFav()
        {
            IsFavorite = !isFavorite;
        }
    }
}
