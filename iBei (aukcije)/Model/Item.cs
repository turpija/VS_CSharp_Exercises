using iBei.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBei.Model
{
    internal class Item : IItem
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public ICategory Category { get; set; }
    }
}
