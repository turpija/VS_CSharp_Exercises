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
                StartProgram();
                Console.Write("Upiši svoje ime: ");
                string ime = Console.ReadLine();

                Console.WriteLine($"Dobrodošao, {ime}!");
                EndProgram();
            }

            void SayHelloVertically()
            {
                StartProgram();
                Console.Write("Upiši svoje ime: ");
                string ime = Console.ReadLine();

                Console.WriteLine("Dobrodošao:");
                for (int i = 0; i < ime.Length; i++)
                {
                    Console.WriteLine($" {ime[i]}");
                }
                EndProgram();
            }

            void CalculateCircleArea()
            {
                StartProgram();
                Console.WriteLine("Izračunaj površinu kružnice");
                Console.Write("Upiši polumjer: ");
                string radiusStr = Console.ReadLine();
                double radius;
                if (double.TryParse(radiusStr, out radius))
                {
                    Console.Write($"Površina kružnice (čiji je polumjer = {radius}) jest = {Math.PI * Math.Pow(radius, 2)}");
                }
                EndProgram();
            }

            void SumArray()
            {
                StartProgram();
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
                EndProgram();
            }

            void BeautifyString()
            {
                StartProgram();
                Console.WriteLine("LET's MAKE THIS PRETTY (barem 6 znakova): ");
                string input = Console.ReadLine();
                if (input.Length >= 6)
                {
                    string pocetak = input.Substring(0, 2).ToUpper();
                    string izmedju = input.Substring(2, input.Length - 2).ToLower();
                    string kraj = input.Substring(input.Length - 2, 2).ToUpper();
                    Console.WriteLine();
                    Console.WriteLine($"..:: {pocetak}{izmedju}{kraj} ::..");
                }
                EndProgram();
            }

            void StartProgram()
            {
                Console.Clear();
            }

            void EndProgram()
            {
                Console.WriteLine();
                Console.Write("...press anykey to return to MainMenu...");
                Console.ReadKey();
                StartProgram();
            }

            void Selector()
            {
                Console.Clear();
                ConsoleKeyInfo keyPress;
                do
                {
                    Console.WriteLine("--== the SELECTOR 9000 ==--");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine();
                    Console.WriteLine("(1) SayHello");
                    Console.WriteLine("(2) SayHelloVertical");
                    Console.WriteLine("(3) CalculateCircleArea");
                    Console.WriteLine("(4) SumArray");
                    Console.WriteLine("(5) BeautifyString");
                    Console.WriteLine();
                    Console.Write("Type number of choice you wish to make (Esc to exit):");
                    keyPress = Console.ReadKey();

                    switch (keyPress.Key.ToString())
                    {
                        case "D1": SayHello(); break;
                        case "D2": SayHelloVertically(); break;
                        case "D3": CalculateCircleArea(); break;
                        case "D4": SumArray(); break;
                        case "D5": BeautifyString(); break;
                        default:
                            break;
                    }
                } while (keyPress.Key != ConsoleKey.Escape);
            }

            Selector();


            //Console.ReadLine();
        }
    }
}
