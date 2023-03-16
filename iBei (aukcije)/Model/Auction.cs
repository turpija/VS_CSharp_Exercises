using iBei.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Model
{
    internal class Auction : IAuction
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public Guid SellerId { get; set; }
        public IUser Seller { get; set; }
        public DateTime EndTime { get; set; }
        public IItem Item { get; set; }
        public ICollection<Bid> Bids { get; set; }
        public Auction()
        {
            Id = Guid.NewGuid();
            Bids = new Collection<Bid>();
        }

        public void GetBids()
        {

        }
    }
}
