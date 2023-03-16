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
        public Guid Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public ICollection<IAuction> Auctions { get; set; }

        public User ()
        {
            Auctions = new Collection<IAuction>();
        }
    }
}
