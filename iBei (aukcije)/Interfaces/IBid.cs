using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Interfaces
{
    internal interface IBid
    {
        Guid Id { get; }
        Guid UserId { get; set; }
        IUser User { get; set; }
        Guid AuctionId { get; set; }
        IAuction Auction { get; }
        double BidPrice { get; set; }
        DateTime BidTime { get; set; }
    }
}
