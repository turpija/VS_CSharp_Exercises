using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReadWrite
{
    internal class FileCopyExercise
    {
        public FileCopyExercise()
        {

            // get directories
            string directoryPath = @"C:\Users\turpija\Documents\Temp";
            
            string[] listaDir = Directory.GetDirectories(directoryPath);
            foreach (var item in listaDir)
            {
                Console.WriteLine(item);
            }

            //get files
            string filesPath = @"C:\Users\turpija\Documents\Temp\Vjezba";
            
            string[] fileLista = Directory.GetFiles(filesPath);
            foreach (var file in fileLista)
            {
                var info = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes, created at: {info.CreationTime}");
            }

            //copy file
            string fileFrom = @"C:\Users\turpija\Documents\Temp\Vjezba\NoviTekst.txt";
            string fileTo = @"C:\Users\turpija\Documents\Temp\Vjezba\NoviTekstKopija.txt";
            File.Copy(fileFrom, fileTo,true);
        }
    }
}
