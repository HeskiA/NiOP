using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HeskiAntonioSystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string putanja = @"C:\Users\Učenik\Documents";
            if(Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke: ");
                foreach(string datoteka in Directory.GetFileSystemEntries(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }


            string mapa1 = putanja + "\\test";
            if(Directory.Exists(mapa1))
            {
                Console.WriteLine("\nMapa postoji.");
                Directory.Delete(mapa1);
                Console.WriteLine("Mapa izbrisana.");
            }
            else
            {
                Directory.CreateDirectory(mapa1);
                Console.WriteLine("mapa test kreirana.");
            }

            //ispis podmapi
            foreach(string datoteka in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(datoteka);
            }

            string[] putanje = Directory.GetFileSystemEntries(putanja);
            Console.WriteLine("Ima " + putanje.Length + "fileova ili foldera ");

            Console.ReadKey();



        }
    }
}
