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
                Console.WriteLine("UPISIVAČ OSOBA");
                Console.WriteLine("--------------");
                Console.Write("Upiši ime osobe: ");
                string ime = Console.ReadLine();

                Console.Write("upiši datum rođenja (godina,mjesec,dan): ");
                DateTime datum = InputDate();
                //DateTime datum = DateTime.Parse(Console.ReadLine());

                //Console.WriteLine("datum"+datum);
                popis.Add(new Person(ime, datum));

                Console.WriteLine("\n<Enter> to continue, <Escape> to exit");
                keyPress = Console.ReadKey();

            } while (keyPress.Key != ConsoleKey.Escape);

            Console.Clear();
            Console.WriteLine("UPISANE OSOBE");
            Console.WriteLine("-------------");
            foreach (Person osoba in popis)
            {
                Console.WriteLine("{0} ima {1} godina", osoba.Name, osoba.CurrentAge);
            }
            Console.ReadLine();
        }

        private DateTime InputDate()
        {
            bool datumOk = false;
            DateTime datum = new DateTime();
            do
            {
                string input = Console.ReadLine();
                try
                {
                    datum = DateTime.Parse(input);
                    Console.WriteLine(datum);
                    datumOk = true;
                }
                catch (Exception)
                {
                    Console.Write("ne va lja!, probaj ponovo: ");
                }

            } while (!datumOk);

            return datum;
        }


    }
}
