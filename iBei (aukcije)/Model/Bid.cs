using iBei.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Model
{
    internal class Bid : IBid
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public IUser User { get; set; }
        public Guid AuctionId { get; set; }
        public IAuction Auction { get; set; }
        public double BidPrice { get; set; }
        public DateTime BidTime { get; set; }

        public Bid(Auction auction, User user, Double price)
        {
            Id = Guid.NewGuid();
            Auction = auction;
            AuctionId = auction.Id;
            User = user;
            UserId = user.Id;
            BidPrice = price;
            BidTime = DateTime.Now;
        }
    }
}
