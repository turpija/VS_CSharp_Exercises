using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person darko = new Person("Darko", new DateTime(1983, 1, 1));
            Console.WriteLine($"Ime:{darko.Name}, Godina:{darko.Age}");
        }
    }
}
