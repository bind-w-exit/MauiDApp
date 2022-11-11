using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ItemViewModel(Item item)
        {
            Id = item.Id;
            ImageUrl = item.ImageUrl;
            Title = item.Title;
            Creator = item.Creator;
            IsFavorite = item.IsFavorite;
        }

        [RelayCommand]
        void ItemFav()
        {
            IsFavorite = !isFavorite;
        }
    }
}
