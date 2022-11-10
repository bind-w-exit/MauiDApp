using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDApp.Models
{
    [INotifyPropertyChanged]
    public partial class Item
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }

        //The ObservableCollection will execute property changed events
        //when you add or remove something from the list,
        //but it is not watching objects' properties. 🤡
        [ObservableProperty]
        private bool isFavorite;

        public Item(int id, string imageUrl, string title, string creator, bool isFavorite)
        {
            Id = id;
            ImageUrl = imageUrl;
            Title = title;
            Creator = creator;
            IsFavorite = isFavorite;
        }
    }
}
