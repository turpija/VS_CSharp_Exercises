using OOPbasics.PrimjerDrugi;
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
            List<WebPost> stranica = new List<WebPost>();

            Person darko = new Person("Darko", new DateTime(1980, 4, 4));
            WebPost post = new WebPost("Aktualnosti dana", "bilo je svega i svačega", darko);
            stranica.Add(post);

            Person marko = new Person("Marko", new DateTime(1992, 6, 6));
            WebPost post2 = new WebPost("Sport danas", "bolji je pobjedio", marko);
            post2.Featured = true;
            stranica.Add(post2);


            Person jurica = new Person("Jurica", new DateTime(1999, 3, 6));
            WebPost post3 = new WebPost("Horskop", "vaga će prevagnuti", jurica);
            stranica.Add(post3);


            foreach (var item in stranica)
            {
                if (item.Featured == true)
                {
                    Console.WriteLine("=======");
                    Console.WriteLine(item.ShowPost());
                    Console.WriteLine("=======");


                }
                else
                {
                    Console.WriteLine("-------");
                    Console.WriteLine(item.ShowPost());
                    Console.WriteLine("-------");

                }
            }

        }
    }
}
