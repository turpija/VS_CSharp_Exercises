using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string directoryPath = @"C:\Users\turpija\Documents\Temp\Vjezba";
            string fileName = "NoviTekst.txt";
            string filePath = Path.Combine(directoryPath, fileName);

            // create folder if it doesn't exists
            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Directory error: {0}", e.ToString());
                throw;
            }

            // open or create file if it doesn't exists
            // insert text into

            string unos = "jednostavan tekst\nu više linija";
            string[] unosArr = new[] { "a može i array: prva linija", "pa onda: druga linija", "i onda: treca linija" };

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                //unos stringa
                sw.WriteLine(unos);
                //unos arraya
                for (int i = 0; i < unosArr.Length; i++)
                {
                    sw.WriteLine(unosArr[i]);
                }
            }

            // read from file, display to console

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }

            //kopiraj iz fajla pa ubaci u drugi + dodaj 
            using (StreamReader sr = new StreamReader(filePath))
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(directoryPath, "najnoviji.txt")))
                {
                    sw.WriteLine("-- početak kopiranog teksta --");
                    while (sr.Peek() >= 0)
                    {
                        sw.WriteLine("-> " + sr.ReadLine());
                    }
                    sw.WriteLine("-- kraj kopiranog teksta --");

                }
            }



        }
    }
}
