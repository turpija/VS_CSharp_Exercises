using iBei.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create new section
            Section tehnikaSection = new Section("tehnika");

            //create new category
            Category telefoni = new Category("telefoni", tehnikaSection);

            //create new user
            User darko = new User("Darko");
            User marko = new User("Marko");

            // create new Item
            Item huawei = new Item()
            {
                Name = "Huawei MX54-300",
                Description = "najsuper, kao novi, prilika",
                Category = telefoni,
                CategoryId = telefoni.Id
            };
            Item laptop = new Item()
            {
                Name = "Macbook Pro"
            };

            // create new auction
            Auction aukcijaHuawei = new Auction()
            {
                Seller = darko,
                SellerId = darko.Id,
                IsActive = true,
                EndTime = DateTime.Now.AddDays(30),
                Item = huawei
            };
            darko.Auctions.Add(aukcijaHuawei);

            Auction aukcijaLaptop = new Auction()
            {
                Seller = darko,
                SellerId = darko.Id,
                IsActive = true,
                EndTime = DateTime.Now.AddDays(25),
                Item = laptop
            };
            darko.Auctions.Add(aukcijaLaptop);


            //create new bids on auction
            Bid bidHuawei = new Bid(aukcijaHuawei, marko, 13.50);
            marko.Bids.Add(bidHuawei);
            aukcijaHuawei.Bids.Add(bidHuawei);

            Bid bidHuawei2 = new Bid(aukcijaHuawei, darko, 18.40);
            darko.Bids.Add(bidHuawei2);
            aukcijaHuawei.Bids.Add(bidHuawei2);

            Bid bidLaptop = new Bid(aukcijaLaptop, marko, 245);
            marko.Bids.Add(bidLaptop);
            aukcijaLaptop.Bids.Add(bidLaptop);

            marko.GetMyBids();
            darko.GetMyAuctions();

            // get auctions ...
            foreach (var aukcija in darko.Auctions)
            {
                Console.WriteLine("darkove aukcije: {0}", aukcija.Item.Name);
            }


            Console.WriteLine("HUAWEI AUKCIJA details");
            foreach (var item in aukcijaHuawei.Bids)
            {
                Console.Write("item: {0}", item.Auction.Item.Name);
                Console.Write(", bid price: {0} ", item.BidPrice);
                Console.Write(", bidder: {0}", item.User.Username);
                Console.Write(", at time: {0}", item.BidTime);
                Console.WriteLine("");
            }

        }
    }
}