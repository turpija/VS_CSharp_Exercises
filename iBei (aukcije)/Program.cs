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

            // create new Item
            Item huawei = new Item()
            {
                Name = "Huawei MX54-300",
                Description = "najsuper, kao novi, prilika",
                Category = telefoni,
                CategoryId = telefoni.Id,
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

            //create new bid on auction
            Bid bidHuawei = new Bid(aukcijaHuawei,darko, 13.50);
        }
    }
}