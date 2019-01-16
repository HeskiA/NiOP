using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HeskiAntonioStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //reader ne writer
            StreamReader sr = new StreamReader(@"C:\Users\Ucenik\Desktop\datoteka.txt");
            
            while(!sr.EndOfStream)
            {

                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();

            Console.ReadKey();
        }
    }
}
