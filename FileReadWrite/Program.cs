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
            //read write exercise using StreamWriter & StreamReader
            ReadWriteTekstFile rwExercise = new ReadWriteTekstFile();
                rwExercise.Main();


        }
    }
}
