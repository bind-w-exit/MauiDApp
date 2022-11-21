using MauiDApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MauiDApp.Services
{
    public static class NftService
    {
        private static int Id = 0;
        private static string[] Titles =
        {
            "SOL #74",
            "Mint Pass #247",
            "QQL #150",
            "Kennel Crew Socks #3140",
            "Friendship Bracelets #23167",
            "1111 #1062",
            "Contractions #169",
            "Lofi Guy #021",
            "Desperate ApeWife #1971",
            "Level 17 at {11, 4}",
            "Genesis Box #4117",
            "Bears Deluxe #349",
            "Decal by Grant Yun #11",
            "Project Atama #403",
            "martyrdom",
            "Monomyth #1160",
            "Fragments by James Jean #2828",
            "CryptoSimeji #3498"

        };
        private static string[] Images =
        {
            @"https://dl.openseauserdata.com/cache/originImage/files/68fb6b2c90323c760ff3892425e964a6.png",
            @"https://dl.openseauserdata.com/cache/originImage/files/0890fc85f2e10efab14b2cac3405d986.png",
            @"https://dl.openseauserdata.com/cache/originImage/files/63038c96b07362b8a6a87415821c4223.png",
            @"https://dl.openseauserdata.com/cache/originImage/files/2f45417bf4cf72d1f2d6580020fc1337.png",
            @"https://dl.openseauserdata.com/cache/originImage/files/1275cd28cb2877afaf6c20fce362b3a5.png",
            @"https://dl.openseauserdata.com/cache/originImage/files/9ec4a8fde03c7c591a9fa3d5a8298128.png",
            @"https://dl.openseauserdata.com/cache/originImage/files/93676f8ab0d9e49cbcc6aa1e07d6e2f2.png",
            @"https://dl.openseauserdata.com/cache/originImage/files/cd3310de5e485a9c89a1f5590899421b.png",
            @"https://dl.openseauserdata.com/cache/originImage/files/2ac145d70919674c9f3af1c4074e4a37.png",
            @"https://dl.openseauserdata.com/cache/originImage/files/bc17220f2054655a0524438a3ac0e593.jpg",
            @"https://dl.openseauserdata.com/cache/originImage/files/8fb2f89c759a228de602e92a077ea783.jpg",
            @"https://dl.openseauserdata.com/cache/originImage/files/e2ceea8f0e7ae4e1225dc148d8dc510e.jpg",
            @"https://dl.openseauserdata.com/cache/originImage/files/3bbdbe1051c46ef76fe7f99f919d194d.gif",
            @"https://dl.openseauserdata.com/cache/originImage/files/bbfc79049e2742873e6abf7d7e9acaf8.gif",
            @"https://dl.openseauserdata.com/cache/originImage/files/1168051e8046af4d3a268e77c0c3288c.gif",
            @"https://dl.openseauserdata.com/cache/originImage/files/2d15e7af0ed043a46779c8669678ba6c.gif",
            @"https://dl.openseauserdata.com/cache/originImage/files/02fe1fa5ca9f9fbb936cd3967fafdb3b.gif",
            @"https://dl.openseauserdata.com/cache/originImage/files/72df1c7aebe7a072f3882a3c5b3fa4ff.gif"
        };
        private static string[] Creators =
        {
            "A874AA",
            "TeamKPR",
            "OthersideMeta",
            "RareLabs_Deployer",
            "911143",
            "SrPetersETH",
            "Cory_Haber",
            "TylerHobbsXDandelionWist",
            "WagmiSan",
            "Art_Blocks",
            "ABOSCH",
            "Art_Blocks",
            "Lofi-Guy-Deployer",
            "DAWCompany",
            "Mathcastles",
            "MCC_V",
            "glid3r_vault"
        };
        private static Random random = new Random();

        public static readonly float ETHPrice = 1123.77F;

        public static Item GetItem()
        {
            string title = Titles[random.Next(Titles.Length)];
            string imageUrl = Images[random.Next(Images.Length)];
            string creator = Creators[random.Next(Creators.Length)];
            bool isFovorite = random.Next(2) == 0;
            double reservedPrice = random.NextDouble() * (5.0 - 0.001) + 0.001;

            return new Item(Id++, imageUrl, title, creator, isFovorite, reservedPrice);
        }
    }
}
