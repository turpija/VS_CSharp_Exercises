using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Interfaces
{
    internal interface ISection
    {
        Guid Id { get; }
        string Name { get; set; }
        ICollection<ICategory> Categories { get; set; }
    }
    
}
