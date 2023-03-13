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
            void SayHello()
            {
                Console.Write("Upiši svoje ime: ");
                string ime = Console.ReadLine();
                Console.WriteLine($"Dobrodošao, {ime}!");
            }

            SayHello();
            Console.ReadLine();
        }
    }
}
