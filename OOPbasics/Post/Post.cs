using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbasics.PrimjerDrugi
{
    internal abstract class Post : IPost
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public virtual string ShowPost()
        {
            return String.Format("{0}\n{1}\n{2}", Title, Description, CreatedAt.Date);
        }
    }
}
