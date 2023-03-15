using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbasics
{
    public class UpisiOsobe
    {
        public void MainMenu()
            {
                Console.Clear();

                ConsoleKeyInfo keyPress;
                List<Person> popis = new List<Person>();

                do
                {
                    Console.Write("Upiši ime osobe: ");
                    string ime = Console.ReadLine();

                    Console.Write("upiši datum rođenja (godina,mjesec,dan): ");
                    DateTime datum = DateTime.Parse(Console.ReadLine());

                    //Console.WriteLine("datum"+datum);
                    popis.Add(new Person(ime, datum));

                    Console.WriteLine("\n<Enter> to continue, <Escape> to exit");
                    keyPress = Console.ReadKey();

                } while (keyPress.Key != ConsoleKey.Escape);

                Console.Clear();

                foreach (Person osoba in popis)
                {
                    Console.WriteLine("Ime osobe: {0}, godina: {1}", osoba.Name, osoba.Age);
                }
                Console.ReadLine();
            }
    }
}
