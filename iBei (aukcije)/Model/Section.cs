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
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<ICategory> Categories { get; set; }

        public Section(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
            Categories = new Collection<ICategory>();
        }
    }
}
