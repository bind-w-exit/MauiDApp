namespace MauiDApp.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public bool IsFavorite { get; set; }
        public double ReservePrice { get; set; }


        public Item(int id, string imageUrl, string title, string creator, bool isFavorite, double reservePrice)
        {
            Id = id;
            ImageUrl = imageUrl;
            Title = title;
            Creator = creator;
            IsFavorite = isFavorite;
            ReservePrice = reservePrice;
        }
    }
}
