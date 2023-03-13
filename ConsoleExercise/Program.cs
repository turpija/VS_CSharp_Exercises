using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
                if (double.TryParse(radiusStr, out radius))
                {
                    Console.Write($"Površina kružnice (čiji je polumjer = {radius}) jest = {Math.PI * Math.Pow(radius, 2)}");
                }
            }

            void SumArray()
            {
                Console.Write("upiši niz brojeva: ");
                string input = Console.ReadLine();
                //string input = "324 4578:6745,23 a bb 2";
                double sum = 0;
                char[] divider = { ' ', ',', ':', ';', '\t' };

                string[] inputArray = input.Split(divider);

                foreach (var str in inputArray)
                {
                    double num;
                    if (double.TryParse(str, out num))
                    {
                        sum += num;
                    }
                }
                Console.WriteLine($"Zbroj svih brojeva u nizu = {sum}"); //11672
            }

            void BeautifyString()
            {
                Console.WriteLine("LET's MAKE THIS PRETTY (barem 6 znakova): ");
                string input = Console.ReadLine();
                if (input.Length >= 6)
                {
                    string pocetak = input.Substring(0, 2).ToUpper();
                    string izmedju = input.Substring(2, input.Length - 2).ToLower();
                    string kraj = input.Substring(input.Length - 2, 2).ToUpper();
                    Console.WriteLine($"..:: {pocetak}{izmedju}{kraj} ::..");
                }
            }

            //SayHello();
            //SayHelloVertically();
            //CalculateCircleArea();
            //SumArray();
            BeautifyString();

            Console.ReadLine();
        }
    }
}
