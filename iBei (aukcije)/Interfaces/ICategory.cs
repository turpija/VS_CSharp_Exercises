using iBei__aukcije_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Interfaces
{
    internal interface ICategory
    {
        Guid Id { get; }
        string Name { get; set; }
        Guid SectionId { get; set; }
        ISection Section { get; set; }
        ICollection<IItem> Items { get; set; }
    }
}
