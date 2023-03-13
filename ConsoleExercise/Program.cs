using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void SayHello(string imeValue)
            {
                Console.WriteLine($"Dobrodošao, {imeValue}!");
            }

            void SayHelloVertically(string imeValue)
            {
                Console.WriteLine("Dobrodošao:");
                for (int i = 0; i < imeValue.Length; i++)
                {
                Console.WriteLine($" {imeValue[i]}");
                }
            }


            Console.Write("Upiši svoje ime: ");
            string ime = Console.ReadLine();

            //SayHello(ime);
            SayHelloVertically(ime);

            Console.ReadLine();
        }
    }
}
