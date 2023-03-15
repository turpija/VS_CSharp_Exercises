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


            bool datumOk = false;
            do
            {
                DateTime datum;
                string input = Console.ReadLine();
                try
                {
                    datum = DateTime.Parse(input);
                    Console.WriteLine(datum);
                    datumOk = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("ne va lja");
                }

            } while (!datumOk);





        }
    }
}
