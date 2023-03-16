using iBei.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace iBei.Model
{
    internal class Category : ICategory
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public Guid SectionId { get; set; }
        public ISection Section { get; set; }
        public ICollection<IItem> Items { get; set; }

        public Category(string name, Section section)
        {
            Name = name;
            Section = section;
            Id = Guid.NewGuid();
            Items = new Collection<IItem>();
        }
    }
}
