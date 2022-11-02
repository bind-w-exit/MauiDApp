using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public bool IsFavorite { get; set; }

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
