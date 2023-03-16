using iBei.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Model
{
    internal class User : IUser
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public ICollection<IAuction> Auctions { get; set; }
        public ICollection<IBid> Bids { get; set; }

        public User(string username)
        {
            Username = username;
            Id = Guid.NewGuid();
            Auctions = new Collection<IAuction>();
            Bids = new Collection<IBid>();
        }

        public void GetMyAuctions()
        {
            Console.WriteLine("{0} have {1} active auctions.", Username, Auctions.Count);
        }
        public void GetMyBids()
        {
            Console.WriteLine("{0} are bidding on {1} auctions.",Username, Bids.Count);
        }
    }
}
