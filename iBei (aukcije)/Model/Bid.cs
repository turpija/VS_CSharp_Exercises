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
        public Guid Id { get; }
        public Guid UserId { get; set; }
        public IUser User { get; }
        public Guid AuctionId { get; set; }
        public IAuction Auction { get; }
        public double BidPrice { get; set; }
        public DateTime BidTime { get; set; }
    }
}
