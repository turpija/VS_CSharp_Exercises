using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbasics.PrimjerDrugi
{
    internal interface IPost
    {
        string Title { get; set; }
        string Description { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
