using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDApp.Models;
using MauiDApp.Services;
using System.Globalization;

namespace MauiDApp.ViewModels;

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

    [ObservableProperty]
    private string timeLeft = "00:00";

    private TimeSpan _timeLeft;
    private IDispatcherTimer _timer;

    public string ReservePriceEth { get => Math.Round(reservePrice, 2).ToString("F2", new CultureInfo("en-US", false)) + " ETH"; }
    public string ReservePriceUsd { get => (reservePrice * NftService.ETHPrice).ToString("C", new CultureInfo("en-US", false)); }

    public ItemViewModel(Item item)
    {
        Id = item.Id;
        ImageUrl = item.ImageUrl;
        Title = item.Title;
        Creator = item.Creator;
        IsFavorite = item.IsFavorite;
        ReservePrice = item.Price;

        if (item.EndTime > DateTime.Now)
        {
            _timeLeft = item.EndTime - DateTime.Now;
            //startTimer(); //TODO
        }
        TimeLeft = _timeLeft.ToString(@"mm\:ss");
    }

    [RelayCommand]
    void ItemFav()
    {
        IsFavorite = !isFavorite;
    }

    void startTimer()
    {
        _timer = Application.Current.Dispatcher.CreateTimer();
        _timer.Interval = TimeSpan.FromSeconds(1);
        _timer.Tick += (s, e) => DoSomething();
        _timer.Start();
    }

    async Task DoSomething()
    {
        await Task.Run(() =>
        {
            _timeLeft -= TimeSpan.FromSeconds(1);

            //Update visual representation here
            //Remember to do it on UI thread

            if (_timeLeft <= TimeSpan.Zero)
            {
                TimeLeft = TimeSpan.Zero.ToString(@"mm\:ss");
                _timer.Stop();
            }
            else
            {
                TimeLeft = _timeLeft.ToString(@"mm\:ss");
            }
        });
    }
}
