using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbasics
{
    internal class Person : IPerson
    {
        public string Name { get; }
        public DateTime Birthdate { get; }
        public int CurrentAge
        {
            get
            {
                return DateTime.Now.Year - Birthdate.Year;
            }
        }

        public Person(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}
