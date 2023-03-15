using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbasics.PrimjerDrugi
{
    internal class WebPost : Post
    {
        public Person Author { get; set; }

        public bool Featured { get; set; }
        public WebPost(string title, string description, Person author) : base(title, description)
        {
            Author = author;
        }

        public override string ShowPost()
        {
            return String.Format("{0}\n{1}\n{2}, {3}", Title.ToUpper(), Description, CreatedAt, Author.Name);
        }
    }
}
