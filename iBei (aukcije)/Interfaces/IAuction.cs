using iBei.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Interfaces
{
    internal interface IAuction
    {
        Guid Id { get; set; }
        bool IsActive { get; set; }
        Guid SellerId { get; set; }
        IUser Seller { get; set; }
        DateTime EndTime { get; set; }
        IItem Item { get; set; }
        ICollection<Bid> Bids { get; set; }


    }
}
