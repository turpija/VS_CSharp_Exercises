using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbasics
{
    internal class Person : IPerson
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birthdate.Year;
            }
            set { }
        }

        public Person(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}
