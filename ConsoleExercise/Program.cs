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

            void SayHelloVertically()
            {
                Console.Write("Upiši svoje ime: ");
            string ime = Console.ReadLine();

                Console.WriteLine("Dobrodošao:");
                for (int i = 0; i < ime.Length; i++)
                {
                Console.WriteLine($" {ime[i]}");
                }
            }

            void CalculateCircleArea()
            {
                Console.WriteLine("Izračunaj površinu kružnice");
                Console.Write("Upiši polumjer: ");
                string radiusStr = Console.ReadLine();
                double radius;
                if(double.TryParse(radiusStr, out radius))
                {
                Console.Write($"Površina kružnice (čiji je polumjer = {radius}) jest = {Math.PI * Math.Pow(radius, 2)}");
                }
            }


            
            //SayHello(ime);
            //SayHelloVertically(ime);
            CalculateCircleArea();

            Console.ReadLine();
        }
    }
}
