using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Interfaces
{
    internal interface IUser
    {
        Guid Id { get; }
        string Username { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        bool IsActive { get; set; }
        ICollection<IAuction> Auctions { get; set; }

    }
}
