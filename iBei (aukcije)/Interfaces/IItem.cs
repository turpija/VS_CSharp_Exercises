using iBei.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Interfaces
{
    internal interface IItem
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        Guid CategoryId { get; set; }
        ICategory Category { get; set; }
    }
}
