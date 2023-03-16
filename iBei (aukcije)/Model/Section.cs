using iBei.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Model
{
    internal class Section : ISection
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public ICollection<ICategory> Categories { get; set; }

        public Section()
        {
            Categories = new Collection<ICategory>();
        }
    }
}
